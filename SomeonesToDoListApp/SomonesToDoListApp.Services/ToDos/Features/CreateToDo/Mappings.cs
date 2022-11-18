using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.CreateToDo
{
    public static class Mappings
    {

        public static ToDo ToEntity(this CreateToDoCommand command)
        {
            return new ToDo
            {
                ToDoItem = command.ToDoItem
            };
        }

        public static CreateToDoDto ToDto(this ToDo entity)
        {
            return new CreateToDoDto { Id = entity.Id };
        }
    }
}
