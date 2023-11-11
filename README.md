<h1>Документация к Api.</h1>

<h3>Модели:</h3>  

<ul>
  <li>TodoItem:</li>
  <ul>
    <li>int Id - Идентификатор записи</li>
    <li>string Name - Имя записи</li>
    <li>int UserId - Идентификатор пользователя</li>
    <li>DateOnly CreatedDate - Дата создания записи</li>
    <li>bool Priority - Приоритетность записи (true - Важно, false - Неважно)</li>
  </ul>


  <li>User:</li>
  <ul>
    <li>int Id - Идентификатор пользователя </li>
    <li>string UserName - Логин пользователя</li>
    <li>string Name - Имя пользователя</li>
    <li>dateOnly Birthday - Дата рождения пользователя</li>
  </ul>
</ul>

  
   
   
   
  
Методы: 
User/CreateAccount: при тестировании через Swagger необходимо ввести userName, name и birthday. 
ToDo/AddToDo: при тестировании через Swagger необходимо ввести name, userId, createdDate и priority. 
ToDo/GetAllToDo: при тестировании через Swagger необходимо ввести parameter и login. Parameter представляет из себя данные типа bool. Значение true означает сортировку по дате (от самой давней, до самой недавней), а значение false - сортировку по приоритетности (от самых важных, до неважных). Login - логин пользователя, записи которого надо вернуть. 
