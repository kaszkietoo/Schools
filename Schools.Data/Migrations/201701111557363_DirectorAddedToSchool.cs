namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DirectorAddedToSchool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Director", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Director");
        }
    }
}
