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
using System.Windows.Input;
using VokabelTrainer.ViewModels;

namespace VokabelTrainer.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            Words = new ObservableCollection<WordGroup>();
            SliderMin = 1;
            SliderMax = 90;
            CurrentSliderValue = 30;
            UseTimemode = false;
        }

        private WordsContext words_db = new WordsContext();

        private ObservableCollection<Category> categories;
        public ObservableCollection<Category> Categories
        {
            get
            {
                categories = words_db.Categories.Select(x => x).AsObservableCollection();
                return categories;
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
            if(UseTimemode == true) test = new Wordstrainer(SelectedCategory, true, CurrentSliderValue);
            else if(UseTimemode == false) test = new Wordstrainer(SelectedCategory, true, -1);
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
    }
}
