namespace DB_lib.Migrations
{
    using DB_lib.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<DB_lib.WordsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DB_lib.WordsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Category environment = new Category { CategoryName = "Environment" };
            Category cars = new Category { CategoryName = "Cars" };
            Category food = new Category { CategoryName = "Food" };
            Category colors = new Category { CategoryName = "Colors" };

            WordGroup tree = new WordGroup { Word_en = "tree", Word_ge = "Baum", Category = environment };

            WordGroup apple = new WordGroup { Word_en = "apple", Word_ge = "Apfel", Category = food };
            WordGroup banana = new WordGroup { Word_en = "banana", Word_ge = "Banane", Category = food };

            WordGroup red = new WordGroup { Word_en = "red", Word_ge = "rot", Category = colors };
            WordGroup green = new WordGroup { Word_en = "green", Word_ge = "grün", Category = colors };
            WordGroup blue = new WordGroup { Word_en = "blue", Word_ge = "blau", Category = colors };
            WordGroup black = new WordGroup { Word_en = "black", Word_ge = "schwarz", Category = colors };

            context.Categories.AddOrUpdate(environment);
            context.Categories.AddOrUpdate(cars);
            context.Categories.AddOrUpdate(food);
            context.Categories.AddOrUpdate(colors);


            context.WordGroups.AddOrUpdate(tree);

            context.WordGroups.AddOrUpdate(apple);
            context.WordGroups.AddOrUpdate(banana);

            context.WordGroups.AddOrUpdate(red);
            context.WordGroups.AddOrUpdate(green);
            context.WordGroups.AddOrUpdate(blue);
            context.WordGroups.AddOrUpdate(black);

            context.SaveChanges();


        }
    }
}
