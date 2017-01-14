using System;
using System.Linq;
using Schools.Data.DTO;

namespace Schools.Data.Repositories
{
    public class UserRepository : IDisposable
    {
        private ApplicationDbContext _dbContext;
        public UserRepository()
        {
            _dbContext = new ApplicationDbContext();
        }
        

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public AccountType GetAccountType(string username)
        {
            return _dbContext.Users.Single(u => u.Email == username).AccountType;
        }

        public void Add(UserDTO user)
        {
            var newUser = new Entities.User(user.Name, user.Surname, user.Email, user.AccountType, user.SchoolId, user.EmailConfirmationCode);                        
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
        }

        public bool ConfirmEmail(string code, string passwordHash, string username)
        {
            var user = _dbContext.Users.Single(u => u.Email == username);
            if (user != null)
            {
                if (user.EmailConfirmationCode == code)
                {
                    user.SetPasswordHash(passwordHash);
                    user.ConfirmEmail();
                    _dbContext.SaveChanges();
                    return true;
                }
            }

            return false;
        }
    }
}
