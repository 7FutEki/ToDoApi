using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    /// <summary>
    /// Id - Идентификатор пользователя
    /// UserName - Логин пользователя
    /// Name - Имя пользователя
    /// Birthday - Дата рождения пользователя
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
