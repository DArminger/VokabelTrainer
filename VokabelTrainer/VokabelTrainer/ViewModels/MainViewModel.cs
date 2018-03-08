using DB_lib;
using DB_lib.Entities;
using Microsoft.Win32;
using MVVM.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using VokabelTrainer.ViewModels;

namespace VokabelTrainer.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private WordsContext words_db = new WordsContext();
        private CreateCategoryDialog createCategoryDialog;
        private AddWordDialog addWordDialog;

        public MainViewModel()
        {
            Words = new ObservableCollection<WordGroup>();
            Categories = words_db.Categories.Select(x => x).AsObservableCollection();
            SliderMin = 1;
            SliderMax = 90;
            CurrentSliderValue = 30;
            UseTimemode = false;
            Mode = false;
        }


        private ObservableCollection<Category> categories;
        public ObservableCollection<Category> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                categories = value;
                RaisePropertyChangedEvent(nameof(Categories));
            }
        }

        private ObservableCollection<WordGroup> words;

        public ObservableCollection<WordGroup> Words
        {
            get
            {
                return words;
            }
            set
            {
                words = value;
                RaisePropertyChangedEvent(nameof(Words));
            }
        }

        private Category selectedCategory;
        public Category SelectedCategory
        {
            get
            {
                return selectedCategory;
            }
            set
            {
                selectedCategory = value;
                //Vokablen aufüllen
                Words = words_db.WordGroups.Where(x => x.Category.CategoryId == selectedCategory.CategoryId).Select(x => x).AsObservableCollection();
                RaisePropertyChangedEvent(nameof(SelectedCategory));
            }
        }

        private string searchText;

        public string SearchText {
            get {
                return searchText;
            }
            set {
                searchText = value;
                RaisePropertyChangedEvent(nameof(SearchText));
            }
        }

        private bool mode;
        
        public bool Mode {
            get {
                return mode;
            }
            set {
                mode = value;
                RaisePropertyChangedEvent(nameof(Mode));
            }
        }

        private bool? useTimemode;

        public bool? UseTimemode
        {
            get { return useTimemode; }
            set
            {
                useTimemode = value;
                RaisePropertyChangedEvent(nameof(UseTimemode));
            }
        }


        private int sliderMin;

        public int SliderMin
        {
            get { return sliderMin; }
            set
            {
                sliderMin = value;
                RaisePropertyChangedEvent(nameof(SliderMin));
            }
        }

        private int currentSliderValue;

        public int CurrentSliderValue
        {
            get { return currentSliderValue; }
            set
            {
                currentSliderValue = value;
                RaisePropertyChangedEvent(nameof(CurrentSliderValue));
            }
        }


        private int sliderMax;

        public int SliderMax
        {
            get { return sliderMax; }
            set
            {
                sliderMax = value;
                RaisePropertyChangedEvent(nameof(SliderMax));
            }
        }
        public ICommand Start
        {
            get { return new RelayCommand<string>(DoStart, x => true); }
        }

        private void DoStart(string obj)
        {
            Wordstrainer test = null;
            if (UseTimemode == true) test = new Wordstrainer(SelectedCategory, true, CurrentSliderValue);
            else if (UseTimemode == false) test = new Wordstrainer(SelectedCategory, Mode, -1);
            test.Show();
        }

        public ICommand ExportCategory
        {
            get
            {
                return new RelayCommand<string>(DoExportCategory, x => selectedCategory != null);
            }
        }

        private void DoExportCategory(string obj)
        {
            string json = JsonConvert.SerializeObject(selectedCategory, new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON file | *.json";
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = File.AppendText(saveFileDialog.FileName))
                {
                    sw.WriteLine(json);
                }
            }

        }

        public ICommand ImportCategory
        {
            get
            {
                return new RelayCommand<string>(DoImportCategory, null);
            }
        }

        private void DoImportCategory(string obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON file | *.json";
            openFileDialog.ShowDialog();
            //openFileDialog.ShowDialog() == DialogResult.OK --> erkennt DialgResult nicht????
            if (true)
            {
                if (openFileDialog.FileName.Trim() != string.Empty)
                {
                    using (StreamReader r = new StreamReader(openFileDialog.FileName))
                    {
                        string json = r.ReadToEnd();
                        Category category = JsonConvert.DeserializeObject<Category>(json);
                        Console.WriteLine("Test Import: " + category.WordGroups.Count);
                        words_db.Categories.Add(category);
                        words_db.SaveChanges();
                        Categories = words_db.Categories.Select(x => x).AsObservableCollection();
                    }
                }
            }
        }

        public ICommand CreateCategory
        {
            get
            {
                return new RelayCommand<string>(DoCreateCategory, null);
            }
        }

        private void DoCreateCategory(string obj)
        {
            createCategoryDialog = new CreateCategoryDialog();
            if (createCategoryDialog.ShowDialog() == false)
            {
                if (createCategoryDialog.NewCategory != null) { 
                string newCategory = createCategoryDialog.NewCategory;
                Console.WriteLine("New Category: " + newCategory);
                Category newCat = new Category();
                newCat.CategoryName = newCategory;
                newCat.WordGroups = new List<WordGroup>();
                words_db.Categories.Add(newCat);
                words_db.SaveChanges();
                Categories = words_db.Categories.Select(x => x).AsObservableCollection();
                }
            }

        }

        public ICommand SearchCategory {
            get
            {
                return new RelayCommand<string>(DoSearchCategory, null);
            }
        }

        private void DoSearchCategory(string obj) {
            Console.WriteLine("enter DoSearchCategory");
            if (SearchText == "" || SearchText == " ") {
                Categories = words_db.Categories.Select(x => x).AsObservableCollection();
            }
            else { 
            Categories = words_db.Categories.Where(x => x.CategoryName.ToUpper().Contains(SearchText.ToUpper()))
                .Select(x => x).AsObservableCollection();
            }

        }

        public ICommand AddWord {
            get
            {
                return new RelayCommand<string>(DoAddWord, null);
            }
        }

        private void DoAddWord(string obj) {
            Console.WriteLine("enter DoAddWord");
            addWordDialog = new AddWordDialog();
            if (addWordDialog.ShowDialog() == false)
            {
                if (addWordDialog.NewWordEnglish != null && addWordDialog.NewWordGerman != null)
                {
                    string newWordE = addWordDialog.NewWordEnglish;
                    string newWordG = addWordDialog.NewWordGerman;
                    Console.WriteLine("New Word: " + newWordE + " : " + newWordG);
                    
                    WordGroup newWG = new WordGroup();
                    newWG.Word_en = newWordE;
                    newWG.Word_ge = newWordG;
                    newWG.Category = selectedCategory;
                    words_db.WordGroups.Add(newWG);
                    words_db.SaveChanges();

                    Words = words_db.WordGroups.Where(x => x.Category.CategoryId == selectedCategory.CategoryId)
                        .Select(x => x).AsObservableCollection();
                    
                }
            }


        }



    }
}
