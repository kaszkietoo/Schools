using System;
using Schools.Data.DTO;

namespace Schools.Data.Repositories
{
    public class StudentRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;

        public StudentRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Add(StudentDTO studentDTO)
        {
            _dbContext.Students.Add(new Entities.Student(studentDTO.Number, studentDTO.Name, studentDTO.Surname, studentDTO.ClassId));
            _dbContext.SaveChanges();
        }
    }
}
