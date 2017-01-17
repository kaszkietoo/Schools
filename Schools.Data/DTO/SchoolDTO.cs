using System.Collections.Generic;

namespace Schools.Data.DTO
{
    public class SchoolDTO
    {
        public string Name { get; set; }        
        public string NIP { get; set; }        
        public string Street { get; set; }        
        public string Number { get; set; }        
        public string PostalCode { get; set; }        
        public string City { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Director { get; set; }
        public long Id { get; set; }
        public IEnumerable<TeacherDTO> Teachers { get; set; }
    }
}
