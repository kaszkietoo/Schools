using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.DTO
{
    public class StudentDTO
    {
        public long Id { get; internal set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public IEnumerable<ScoreDTO> Scores { get; set; }
        public string Surname { get; set; }
        public long ClassId { get; set; }
    }
}
