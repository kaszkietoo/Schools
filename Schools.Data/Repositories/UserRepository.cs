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
            _dbContext.Users.Add(new Entities.User(user.Name, user.Surname, user.Email, user.AccountType));
        }
    }
}
