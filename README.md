Документация к Api. 

Модели:  

TodoItem:
  int Id - Идентификатор записи 
  string Name - Имя записи 
  int UserId - Идентификатор пользователя 
  DateOnly CreatedDate - Дата создания записи 
  bool Priority - Приоритетность записи (true - Важно, false - Неважно) 

User: 
  int Id - Идентификатор пользователя 
  string UserName - Логин пользователя 
  string Name - Имя пользователя 
  dateOnly Birthday - Дата рождения пользователя 
  
Методы: 
User/CreateAccount: при тестировании через Swagger необходимо ввести userName, name и birthday. 
ToDo/AddToDo: при тестировании через Swagger необходимо ввести name, userId, createdDate и priority. 
ToDo/GetAllToDo: при тестировании через Swagger необходимо ввести parameter и login. Parameter представляет из себя данные типа bool. Значение true означает сортировку по дате (от самой давней, до самой недавней), а значение false - сортировку по приоритетности (от самых важных, до неважных). Login - логин пользователя, записи которого надо вернуть. 
