using DB_lib;
using DB_lib.Entities;
using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VokabelTrainer.ViewModels;

namespace VokabelTrainer.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Words = new ObservableCollection<WordGroup>();
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





    }
}
