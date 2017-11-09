using DB_lib;
using DB_lib.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

//Versionsverwaltung
//v0.1 Project erstellt + Bildschirmmasken -David Arminger
//v0.2 Datenbank mit Alles erstellt

namespace VokabelTrainer
{
    public partial class MainWindow : Window
    {
        private WordsContext words_db = new WordsContext();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var migration = new MigrateDatabaseToLatestVersion<WordsContext, Configuration>();
            Database.SetInitializer(migration);

            //DB Test
            int test = words_db.Categories.Count();
            Console.WriteLine("DB Test: " + test);

        }


    }
}
