using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VokabelTrainer
{

    public partial class AddWordDialog : Window
    {
        public AddWordDialog() => InitializeComponent();

        private string newWordEnglish = null;
        private string newWordGerman = null;

        public string NewWordEnglish
        {
            get { return newWordEnglish; }
        }

        public string NewWordGerman
        {
            get { return newWordGerman; }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddWordBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            newWordEnglish = text_english.Text;
            newWordGerman = text_german.Text;
        }
    }
}
