using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }
        public bool Add(User user)
        {
            _db.Add(user);
            return Save();
        }
        //Метод проверки на доступность имени
        public bool CheckForFree(User user)
        {
            var userFromDb = _db.Users.FirstOrDefault(x => x.UserName == user.UserName);
            if (userFromDb != null) return false;
            else return true;
        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }
        //Метод получения пользователя по логину
        public User TakeUser(string login)
        {
            var user = _db.Users.FirstOrDefault(x => x.UserName == login);
            if(user == null) return null;
            else return user;
        }
    }
}
