using System.Collections.Generic;

namespace Schools.Data.DTO
{
    public class TeacherDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        public IEnumerable<ClassDTO> Classes { get; set; }
    }
}
