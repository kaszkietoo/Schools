using Schools.Data.Entities;
using System.Data.Entity;

namespace Schools.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Schools")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
