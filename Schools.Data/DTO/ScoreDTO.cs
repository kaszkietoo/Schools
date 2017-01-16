using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.DTO
{
    public class ScoreDTO
    {
        public string FinalScore { get; set; }
        public long Id { get; set; }
        public long SubjectId { get; set; }
        public long StudentId { get; set; }
        public string Subject { get; set; }
    }
}
