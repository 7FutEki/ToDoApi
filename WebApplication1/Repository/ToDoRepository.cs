using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class ToDoRepository : IRepository<TodoItem>
    {
        private readonly ApplicationContext _db;
        public ToDoRepository(ApplicationContext db)
        {
            _db = db;
        }
        public void Add(TodoItem todoItem)
        {
            _db.Add(todoItem);
            _db.SaveChanges();
        }

        public bool Contains(TodoItem entity)
        {
            // TO DO 
            throw new NotImplementedException();
        }

        public TodoItem? Get(string idOrData)
        {
            // TO DO ?????
            throw new NotImplementedException();
        }

        //Метод получения листа записей по идентификатору пользователя
        public ICollection<TodoItem> Get(int userId)
        {
            return _db.TodoItems
                .Where(x =>x.UserId == userId)
                .ToList();
        }
    }
}
