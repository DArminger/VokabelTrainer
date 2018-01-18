using DB_lib;
using DB_lib.Entities;
using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VokabelTrainer.ViewModels
{
    public class TestViewModel : ObservableObject
    {
        Category category;
        List<WordGroup> unusedWords;
        int unusedWordCounter = -1;
        int wordCounter = -1;
        bool englishToGerman;
        public RelayCommand<Window> Cancel { get; private set; }

        public TestViewModel(Category category, bool englishToGerman)
        {
            unusedWords = new List<WordGroup>();
            this.category = category;
            this.englishToGerman = englishToGerman;
            this.Cancel = new RelayCommand<Window>(this.CloseWindow);
            RefreshUIToNextWord(false);

        }

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
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

        private string untranslatedWord;

        public string UntranslatedWord
        {
            get { return untranslatedWord; }
            set
            {
                untranslatedWord = value;
                RaisePropertyChangedEvent(nameof(UntranslatedWord));
            }
        }

        private string translatedWord;

        public string TranslatedWord
        {
            get { return translatedWord; }
            set
            {
                translatedWord = value;
                RaisePropertyChangedEvent(nameof(TranslatedWord));
            }
        }

        private string amountOfWord;

        public string AmountOfWord
        {
            get { return amountOfWord; }
            set
            {
                amountOfWord = value;
                RaisePropertyChangedEvent(nameof(AmountOfWord));
            }
        }

        public ICommand Skip
        {
            get { return new RelayCommand<string>(DoSkip, x => true); }
        }


        private void DoSkip(string obj)
        {
            RefreshUIToNextWord(true);
        }
        public ICommand Show
        {
            get { return new RelayCommand<string>(DoShow, x => true); }
        }
        private void DoShow(string obj)
        {
            if (englishToGerman && wordCounter < category.WordGroups.Count) TranslatedWord = category.WordGroups[wordCounter].Word_ge;
            else if (!englishToGerman && wordCounter < category.WordGroups.Count) TranslatedWord = category.WordGroups[wordCounter].Word_en;
            else if (englishToGerman && wordCounter >= category.WordGroups.Count && unusedWordCounter < unusedWords.Count) TranslatedWord = unusedWords[unusedWordCounter].Word_ge;
            else if (!englishToGerman && wordCounter >= category.WordGroups.Count && unusedWordCounter < unusedWords.Count) TranslatedWord = unusedWords[unusedWordCounter].Word_en;

        }
        public ICommand Check
        {
            get { return new RelayCommand<string>(DoCheck, x => TranslatedWord != "" || TranslatedWord != null); }
        }
        private void DoCheck(string obj)
        {
            if (englishToGerman && wordCounter < category.WordGroups.Count)
            {
                if (category.WordGroups[wordCounter].Word_ge.ToLower().Equals(translatedWord.ToLower())) SetImageAndRefreshUI(true);
                else SetImageAndRefreshUI(false);
            }
            else if (!englishToGerman && wordCounter < category.WordGroups.Count)
            {
                if (category.WordGroups[wordCounter].Word_en.ToLower().Equals(translatedWord.ToLower())) SetImageAndRefreshUI(true);
                else SetImageAndRefreshUI(false);
            }
            else if (englishToGerman && wordCounter >= category.WordGroups.Count && unusedWordCounter < unusedWords.Count)
            {
                if (unusedWords[unusedWordCounter].Word_ge.ToLower().Equals(translatedWord.ToLower())) SetImageAndRefreshUI(true);
                else SetImageAndRefreshUI(false);
            }
            else if (!englishToGerman && wordCounter >= category.WordGroups.Count && unusedWordCounter < unusedWords.Count)
            {
                if (unusedWords[unusedWordCounter].Word_en.ToLower().Equals(translatedWord.ToLower())) SetImageAndRefreshUI(true);
                else SetImageAndRefreshUI(false);
            }
        }

        private void SetImageAndRefreshUI(bool correct)
        {
            if (correct)
            {
                Image = Environment.CurrentDirectory + @"\Pictures\Check.png";
                RefreshUIToNextWord(false);
            }
            else if (!correct) Image = Environment.CurrentDirectory + @"\Pictures\Error.png";
        }

        private string image;

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                RaisePropertyChangedEvent(nameof(Image));
            }
        }




        private void RefreshUIToNextWord(bool wordSkipped)
        {
            wordCounter++;
            int uWDebug = wordCounter - 1;
            if (englishToGerman && wordCounter < category.WordGroups.Count)
            {
                TranslationFromTo = "English - German";
                UntranslatedWord = category.WordGroups[wordCounter].Word_en;
            }
            else if (!englishToGerman && wordCounter < category.WordGroups.Count)
            {
                TranslationFromTo = "German - English";
                UntranslatedWord = category.WordGroups[wordCounter].Word_ge;
            }
            if (wordSkipped && wordCounter <= category.WordGroups.Count)
            {
                unusedWords.Add(category.WordGroups[uWDebug]);
            }
            if (unusedWords.Count != 0 && wordCounter >= category.WordGroups.Count)
            {
                unusedWordCounter++;
                if (englishToGerman && unusedWordCounter < unusedWords.Count)
                {
                    TranslationFromTo = "English - German";
                    UntranslatedWord = unusedWords[unusedWordCounter].Word_en;
                }
                else if (!englishToGerman && unusedWordCounter < unusedWords.Count)
                {
                    TranslationFromTo = "German - English";
                    UntranslatedWord = unusedWords[unusedWordCounter].Word_ge;
                }
            }
            AmountOfWord = $"{wordCounter}/{category.WordGroups.Count}";
            TranslatedWord = "";
        }
    }
}
