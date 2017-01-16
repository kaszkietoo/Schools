using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schools.Web.Models
{
    public class SchoolModel
    {
        public string City { get; internal set; }
        public string Director { get; internal set; }
        public string Email { get; internal set; }
        public string Name { get; internal set; }
        public string NIP { get; internal set; }
        public string Number { get; internal set; }
        public string PostalCode { get; internal set; }
        public string Street { get; internal set; }
        public string Telephone { get; internal set; }
    }
}