using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUserRepository
    {
        public bool Add(User user);
        public bool Save();
        public User TakeUser(string login);
        public bool CheckForFree(User user);
    }
}
