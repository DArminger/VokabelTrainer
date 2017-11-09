namespace DB_lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.WordGroups",
                c => new
                    {
                        WordGroupId = c.Int(nullable: false, identity: true),
                        Word_en = c.String(nullable: false),
                        Word_ge = c.String(nullable: false),
                        Category_CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WordGroupId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WordGroups", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.WordGroups", new[] { "Category_CategoryId" });
            DropTable("dbo.WordGroups");
            DropTable("dbo.Categories");
        }
    }
}
