namespace Schools.Data.Migrations
{    
    using System.Data.Entity.Migrations;    

    internal sealed class Configuration : DbMigrationsConfiguration<Schools.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Schools.Data.ApplicationDbContext context)
        {
            
        }
    }
}
