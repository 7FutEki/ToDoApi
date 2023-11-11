using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IToDoRepository
    {
        public bool Add(TodoItem todoItem);
        public bool Save();
        public List<TodoItem> GetAll(int UserId);
    }
}
