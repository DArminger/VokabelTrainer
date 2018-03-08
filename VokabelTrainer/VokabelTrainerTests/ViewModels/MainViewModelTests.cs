using Microsoft.VisualStudio.TestTools.UnitTesting;
using VokabelTrainer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_lib;

namespace VokabelTrainer.ViewModels.Tests
{
    [TestClass()]
    public class MainViewModelTests
    {
        [TestMethod()]
        public void T1_TestDbConnection()
        {
            var db = new WordsContext();
            Console.WriteLine("Testausgabe: " + db.Categories.Count());
            Assert.AreEqual(true, db.Categories.Count() > 0);
        }
    }
}