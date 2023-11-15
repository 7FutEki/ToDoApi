using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ApplicationContext _db;

        public ToDoRepository(ApplicationContext db)
        {
            _db = db;
        }
        public bool Add(TodoItem todoItem)
        {
            _db.Add(todoItem);
            _db.SaveChanges();
        }
        //Метод получения листа записей по идентификатору пользователя
        public List<TodoItem> GetAll(int UserId)
        {
            return _db.TodoItems.Where(x =>x.UserId == UserId).ToList();
        }
    }
}
