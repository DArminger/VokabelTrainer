using DB_lib.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lib
{
    public class WordsContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<WordGroup> WordGroups { get; set; }

        public WordsContext() : base("WordsMdf") {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }


    }
}
