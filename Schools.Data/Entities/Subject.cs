using System.ComponentModel.DataAnnotations;

namespace Schools.Data.Entities
{
    public class Subject
    {
        [Key]
        public long Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }
    }
}
