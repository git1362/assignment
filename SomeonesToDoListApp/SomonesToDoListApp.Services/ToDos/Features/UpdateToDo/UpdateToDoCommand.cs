using MediatR;

namespace SomonesToDoListApp.Services.ToDos.Features.UpdateToDo
{
    public class UpdateToDoCommand: IRequest<UpdateToDoCommandResponse>
    {
        public int Id { get; set; }
        public string ToDoItem { get; set; } = string.Empty;
    }
}
