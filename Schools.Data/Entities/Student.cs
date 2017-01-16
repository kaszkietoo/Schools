using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schools.Data.Entities
{
    public class Student
    {
        protected Student()
        {

        }

        public Student(string number, string name, string surname, long classId)
        {
            Number = number;
            Name = name;
            Surname = surname;
            ClassId = classId;
        }

        [Key]
        public long Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }
        [Required]
        public string Surname { get; protected set; }
        public virtual ICollection<Score> Scores { get; protected set; }
        [ForeignKey("Class")]
        public long ClassId { get; protected set; }
        public virtual Class Class { get; protected set; }
        [Required]
        public string Number { get; set; }
    }
}
