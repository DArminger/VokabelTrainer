using DB_lib;
using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer.ViewModels
{
    public class TestViewModel : ObservableObject
    {
        WordsContext db;

        public TestViewModel(WordsContext db, bool englishToGerman)
        {
            this.db = db;
            
        }
        private string translationFromTo;

        public string TranslationFromTo
        {
            get { return translationFromTo; }
            set
            {
                translationFromTo = value;
                RaisePropertyChangedEvent(nameof(TranslationFromTo));
            }
        }

    }
}
