using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //Репозиторий для работы с таблицей пользователя в базе данных
        private readonly IRepository<User> _repository;
        public UserController(IRepository<User> repository)
        {
            _repository = repository;
        }

        //Метод для создания аккаунта
        [HttpPost("CreateAccount")]
        public IActionResult CreateAccount([FromBody] User user)
        {
            //Проверка на доступность имени
            if (!_repository.Contains(user)) 
                return BadRequest("Пользователь с таким именем уже есть");
            
            _repository.Add(user);
            return Ok();
        }
    }
}