using MediatR;
using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.UpdateToDo
{
    public static class Mappings
    {

        public static ToDo ToEntity(this UpdateToDoCommand command)
        {
            return new ToDo
            {
                Id = command.Id,
                ToDoItem = command.ToDoItem
            };
        }
    }
}
