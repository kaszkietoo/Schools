using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schools.Data.Entities
{
    public class Class
    {
        protected Class() { }

        public Class(string name, long userId)
        {
            Name = name;
            UserId = userId;
        }

        [Key]
        public long Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }
        public virtual ICollection<Student> Students { get; protected set; }
        [ForeignKey("User")]
        public long UserId { get; protected set; }
        public virtual User User { get; protected set; }

    }
}
