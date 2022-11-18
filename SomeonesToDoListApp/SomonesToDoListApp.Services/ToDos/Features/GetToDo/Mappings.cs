using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDo
{
    public static class Mappings
    {
        public static GetToDoDto ToDto(this ToDo entity)
        {
            return new GetToDoDto
            {
                Id = entity.Id,
                ToDoItemName = entity?.ToDoItem ?? ""

            };
        }
    }
}
