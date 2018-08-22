namespace CodeFirstNewDatabaseExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BlogModels", newName: "Blogs");
            RenameTable(name: "dbo.PostModels", newName: "Posts");
            AddColumn("dbo.Blogs", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Url");
            RenameTable(name: "dbo.Posts", newName: "PostModels");
            RenameTable(name: "dbo.Blogs", newName: "BlogModels");
        }
    }
}
