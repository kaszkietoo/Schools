using System.ComponentModel.DataAnnotations;

namespace Schools.Data.Entities
{
    public class School
    {
        public School(string name, string nip, string street, string number, string postalCode, string city, string email, string telephone, string director)
        {
            Name = name;
            NIP = nip;
            Street = street;
            Number = number;
            PostalCode = postalCode;
            City = city;
            Email = email;
            Telephone = telephone;
            Director = director;
        }

        [Key]
        public long Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }
        [Required]
        public string NIP { get; protected set; }
        [Required]
        public string Street { get; protected set; }
        [Required]
        public string Number { get; protected set; }
        [Required]
        public string PostalCode { get; protected set; }
        [Required]
        public string City { get; protected set; }
        [Required]
        public string Email { get; protected set; }
        [Required]
        public string Telephone { get; protected set; }
        [Required]
        public string Director { get; set; }
    }
}
