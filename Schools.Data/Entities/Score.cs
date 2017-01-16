using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.Entities
{
    public class Score
    {
        protected Score()
        {

        }

        public Score(string finalScore, long studentId, long subjectId)
        {
            FinalScore = finalScore;
            StudentId = studentId;
            SubjectId = subjectId;
        }

        [Key]
        public long Id { get; protected set; }
        [Required]
        public string FinalScore { get; protected set; }
        [ForeignKey("Subject")]
        public long SubjectId { get; protected set; }
        public virtual Subject Subject { get; protected set; }
        [ForeignKey("Student")]
        public long StudentId { get; protected set; }
        public virtual Student Student { get; protected set; }
    }
}
