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
        public IActionResult GetAllToDo(int idUser, string optionsSort)
        {
            var result = _repository.Get(idUser)?.ToList();

            if (result == null || result.Count == 0)
                return NoContent();

            switch (optionsSort.ToLower())
            {
                case "date":
                    result = result.OrderBy(item => item.CreatedDate).ToList();
                    break;
                case "priority":
                    result = result.OrderBy(item => item.Priority).ToList();
                    break;
            }

            // TO DO MAPING RTNtoDO
        }
    

    //Метод создания записи
    [HttpPost("AddToDo")]
    public IActionResult AddTodo([FromBody] TodoItem todoItem)
    {
        _repository.Add(todoItem);
        return Ok();
    }
}

}