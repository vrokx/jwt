using EpicShopAPI.Data;
using EpicShopAPI.Models;

namespace EpicShopAPI.Services
{
    public class UserService
    {
        private readonly MyDbContext _dbContext;

        public UserService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateUser(User newUser)
        {
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
        }
    }
}
