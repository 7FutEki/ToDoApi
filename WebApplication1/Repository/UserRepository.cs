using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _db;
        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }
        public void Add(User user)
        {
            _db.Add(user);
            _db.SaveChanges();
        }
        
        //Метод получения пользователя по логину
        public User? Get(string login)
        {
            var user = _db.Users
                .FirstOrDefault(x => x.UserName == login);
            return user;
        }

        public ICollection<User> Get(int optionsRecords)
        {
            // TO DO?????
            throw new NotImplementedException();
        }
    }
}
