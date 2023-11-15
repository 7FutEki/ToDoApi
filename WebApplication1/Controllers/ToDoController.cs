using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

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

            result = optionsSort.ToLower() switch
            {
                "date" => result.OrderBy(item => item.CreatedDate).ToList(),
                "priority" => result.OrderBy(item => item.Priority).ToList(),
                _ => result
            };

            /* Если название полей одиноковые, то настройка маппера не нужна, мапинг автоматически */
            ICollection<RTNToDo> totalResult = result.Adapt<List<RTNToDo>>();

            return Ok(totalResult);
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