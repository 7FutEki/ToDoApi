namespace WebApplication1.Models
{
    /// <summary>
    /// Id - Идентификатор записи
    /// Name - Имя записи, то есть содержание
    /// UserId - Идентификатор пользователя, к которому относится эта запись
    /// CreatedDate - Дата создания записи
    /// Priority - Приоритетность записи
    /// </summary>
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId   { get; set; }
        public DateOnly CreatedDate { get; set;}
        public bool Priority { get; set; }
    }
}
