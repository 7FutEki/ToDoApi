using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IToDoRepository
    {
        public bool Add(TodoItem todoItem);
        public List<TodoItem> GetAll(int UserId);
    }
}
