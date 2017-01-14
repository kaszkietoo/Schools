using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schools.Data.Entities
{
    public class User
    {
        protected User()
        {

        }

        public User(string name, string surname, string email, AccountType accountType, long schoolId, string emailConfirmationCode)
        {
            EmailConfirmed = false;
            Name = name;
            Surname = surname;
            Email = email;
            AccountType = accountType;
            SchoolId = schoolId;
            EmailConfirmationCode = emailConfirmationCode;
        }

        [Key]
        public long Id { get; protected set; }
        [Required]
        public string Name { get; protected set; }

        internal void SetPasswordHash(string passwordHash)
        {
            PasswordHash = passwordHash;
        }

        [Required]
        public string Surname { get; protected set; }
        [Required]
        public string Email { get; protected set; }
        public AccountType AccountType { get; protected set; }
        public string PasswordHash { get; protected set; }
        public string ResetPasswordCode { get; protected set; }
        public string EmailConfirmationCode { get; protected set; }

        public void ConfirmEmail()
        {
            EmailConfirmationCode = null;
            EmailConfirmed = true;
        }

        public bool EmailConfirmed { get; protected set; }       
        public long? SchoolId { get; set; }        
    }
}
