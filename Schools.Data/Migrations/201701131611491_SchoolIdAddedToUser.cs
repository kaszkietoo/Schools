namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolIdAddedToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SchoolId", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SchoolId");
        }
    }
}
