namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentNumberAddedToEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Number");
        }
    }
}
