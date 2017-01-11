using Schools.Data.DTO;
using System;

namespace Schools.Data.Repositories
{
    public class SchoolRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;

        public SchoolRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Add(SchoolDTO school)
        {
            var addedSchool = _dbContext.Schools.Add(new Entities.School(school.Name, school.NIP, school.Street, school.Number, school.PostalCode, school.City, school.Email, school.Telephone, school.Director));
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
