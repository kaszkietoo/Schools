using Schools.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<SchoolDTO> GetAll()
        {
            return _dbContext.Schools.Select(s => new SchoolDTO
            {
                City = s.City,
                Director = s.Director,
                Email = s.Email,
                Name = s.Name,
                NIP = s.NIP,
                Number = s.Number,
                PostalCode = s.Number,
                Street = s.Street,
                Telephone = s.Telephone,
                Id = s.Id,
                Teachers = _dbContext.Users.Where(u => u.SchoolId == s.Id)
                .Select(u => new TeacherDTO
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    Email = u.Email,
                    IsActive = u.EmailConfirmed ? "Tak" : "Nie",
                    Classes = u.Classes.Select(c => new ClassDTO { Id = c.Id, Name = c.Name }).ToList()
                })
                .ToList()
            }).ToList();
        }
    }    
}
