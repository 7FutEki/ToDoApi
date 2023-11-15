using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        //Репозитории для работы с таблицами пользователя и записей в базе данных;
        private readonly IRepository<TodoItem> _repository;
        public ToDoController(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }
        //Метод для получения ТОР-100 записей с сортировкой
        [HttpGet("GetAllToDo")]
        public IActionResult GetAllToDo(bool parameter, string login)
        {
            User? user = _repository.TakeUser(login);
            if (user == null) return BadRequest("Пользователя с таким именем не существует");
            else
            {
                //Получаем уже отсортированный список по конкретному параметру
                var list = Methods.GetListToDo(parameter, user.Id, _toDoRepository);
                //Если количество записей больше 100, оставляем лишь ТОР-100
                if(list.Count > 100) list.RemoveRange(100, list.Count-100);
                var RTNList = new List<RTNToDo>();

                //Заполняем лист на вывод
                for (int i = 0; i < list.Count; i++)
                {
                    RTNList.Add(new RTNToDo
                    {
                        Title = list[i].Name,
                        Priority = list[i].Priority,
                        CreatedDate = list[i].CreatedDate,
                        Login = user.UserName,
                        Name = user.Name,
                        Birthday = user.Birthday
                    });

                }
            return Ok(RTNList);
            }
        }

        //Метод создания записи
        [HttpPost("AddToDo")]
        public IActionResult AddTodo([FromBody] TodoItem todoItem)
        {

            _toDoRepository.Add(todoItem);
            return Ok();

        }

    }
}
