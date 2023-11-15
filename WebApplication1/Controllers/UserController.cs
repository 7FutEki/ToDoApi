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
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //Метод для создания аккаунта
        [HttpPost("CreateAccount")]
        public IActionResult CreateAccount([FromBody] User user)
        {
            //Проверка на доступность имени
            if (!_userRepository.CheckForFree(user)) 
                return BadRequest("Пользователь с таким именем уже есть");
            
            _userRepository.Add(user);
            return Ok();
        }
    }
}