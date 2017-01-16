using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schools.Data.DTO;

namespace Schools.Data.Repositories
{
    public class ScoreRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;

        public ScoreRepository()
        {
            _dbContext = new ApplicationDbContext();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Add(ScoreDTO scoreDTO)
        {
            _dbContext.Scores.Add(new Entities.Score(scoreDTO.FinalScore, scoreDTO.StudentId, scoreDTO.SubjectId));
            _dbContext.SaveChanges();
        }
    }
}
