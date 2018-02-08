using DB_lib.Entities;
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
using VokabelTrainer.ViewModels;

namespace VokabelTrainer
{
    /// <summary>
    /// Interaction logic for Wordstrainer.xaml
    /// </summary>
    public partial class Wordstrainer : Window
    {
        public Wordstrainer(Category category, bool englishToGerman, int time)
        {
            InitializeComponent();
            this.DataContext = new TestViewModel(category, englishToGerman, time);
        }
    }
}
