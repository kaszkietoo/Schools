namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolEntityUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Schools", "Telephone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Telephone");
            DropColumn("dbo.Schools", "Email");
        }
    }
}
