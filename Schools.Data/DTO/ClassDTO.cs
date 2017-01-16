using System.Collections.Generic;

namespace Schools.Data.DTO
{
    public class ClassDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public IEnumerable<StudentDTO> Students { get; set; }
    }
}
