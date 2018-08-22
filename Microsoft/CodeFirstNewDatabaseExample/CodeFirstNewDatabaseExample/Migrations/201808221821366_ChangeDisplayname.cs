namespace CodeFirstNewDatabaseExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDisplayname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "display_name", c => c.String());
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "display_name");
        }
    }
}
