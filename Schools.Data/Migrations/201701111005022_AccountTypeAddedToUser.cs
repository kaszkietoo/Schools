namespace Schools.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountTypeAddedToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AccountType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AccountType");
        }
    }
}
