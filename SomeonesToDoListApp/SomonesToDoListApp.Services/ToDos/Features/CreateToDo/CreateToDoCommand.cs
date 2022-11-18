using MediatR;

namespace SomonesToDoListApp.Services.ToDos.Features.CreateToDo
{
    public class CreateToDoCommand : IRequest<CreateToDoCommandResponse>
    {
        public string ToDoItem { get; set; } = string.Empty;
    }
}
