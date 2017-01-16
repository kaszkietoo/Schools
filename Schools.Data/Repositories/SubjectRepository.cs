using Schools.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schools.Data.Repositories
{
    public class SubjectRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;

        public SubjectRepository()
        {
            _dbContext = new ApplicationDbContext();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IEnumerable<SubjectDTO> GetAll()
        {
            return _dbContext.Subjects.Select(s => new SubjectDTO { Id = s.Id, Name = s.Name }).ToList();
        }
    }
}
