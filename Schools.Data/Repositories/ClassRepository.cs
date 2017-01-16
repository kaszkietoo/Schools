using Schools.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.Repositories
{
    public class ClassRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;

        public ClassRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Add(ClassDTO classDTO)
        {
            var user = _dbContext.Users.Single(u => u.Email == classDTO.Username);
            _dbContext.Classes.Add(new Entities.Class(classDTO.Name, user.Id));
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IEnumerable<ClassDTO> GetAllForUser(string usename)
        {
            return _dbContext.Users.Single(u => u.Email == usename).
                Classes.Select(c => new ClassDTO {
                    Id = c.Id,
                    Name = c.Name,
                    Students = c.Students.Select(s => 
                        new StudentDTO {
                            Id = s.Id,
                            Number = s.Number,
                            Name = s.Name,
                            Surname = s.Surname,
                            Scores = s.Scores.Select(sc => new ScoreDTO { Id = sc.Id, Subject = sc.Subject.Name, FinalScore = sc.FinalScore }).ToList() }).ToList() }).ToList();
        }
    }
}
