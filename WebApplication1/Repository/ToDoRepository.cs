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
            return Save();
        }
        //Метод получения листа записей по идентификатору пользователя
        public List<TodoItem> GetAll(int UserId)
        {
            return _db.TodoItems.Where(x =>x.UserId == UserId).ToList();
        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
