using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public AccountType AccountType { get; set; }
        public long SchoolId { get; set; }
        public string EmailConfirmationCode { get; set; }
    }
}
