using MediatR;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDo
{
    public class GetToDoQuery: IRequest<GetToDoDto?>
    {
        public int Id { get; set; }
    }
}
