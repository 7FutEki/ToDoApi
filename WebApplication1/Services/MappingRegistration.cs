using Mapster;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class MappingRegistration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TodoItem, RTNToDo>()
            .Map(z => z.Birthday, x => x.User!.Birthday)
            .Map(z => z.CreatedDate, x => x.CreatedDate)
            .Map(z => z.Priority, x => x.Priority)
            .Map(z => z.Name, x => x.User!.Name)
            .Map(z => z.Login, x => x.User!.UserName)
            .Map(z => z.Title, x => x.Name);
    }
}