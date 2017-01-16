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
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
