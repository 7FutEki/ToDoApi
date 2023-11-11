using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Methods
    {
        public static List<TodoItem> GetListToDo(bool parameter, int UserId, IToDoRepository _toDoRepository)
        {
            //Получаем лист записей из бд по конкретному пользователю
            var ListToDo = _toDoRepository.GetAll(UserId);
            switch (parameter)
            {
                case true:
                    return ListDateSort(ListToDo);
                    break;
                case false:
                    return ListPrioritySort(ListToDo);
                    break;
            }
        }

        //Метод сортировки пузырька по приоритетности
        public static List<TodoItem> ListPrioritySort(List<TodoItem> list)
        {
            TodoItem temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (Convert.ToInt32(list[i].Priority) < Convert.ToInt32(list[j].Priority))
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
        //Метод сортировки пузырька по дате
        public static List<TodoItem> ListDateSort(List<TodoItem> list)
        {

            TodoItem temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].CreatedDate > list[j].CreatedDate)
                    {
                        temp = list[i];
                        list[i]= list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
