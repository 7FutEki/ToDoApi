using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUserRepository
    {
        public void Add(User user);
        public User? TakeUser(string login);
        public bool CheckForFree(User user);
    }
}
