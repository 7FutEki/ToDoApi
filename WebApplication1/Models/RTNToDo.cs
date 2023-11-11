namespace WebApplication1.Models
{
    /// <summary>
    /// Title - Имя записи
    /// Priority - Приоритетность записи
    /// CreatedDate - Дата создания записи
    /// Login - Логин пользователя
    /// Name - Имя пользователя
    /// Birthday - Дата рождения пользователя
    /// </summary>

    //Класс для вывода листа
    public class RTNToDo
    {
        public string Title { get; set; }
        public bool Priority { get;set; }
        public DateOnly CreatedDate { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
