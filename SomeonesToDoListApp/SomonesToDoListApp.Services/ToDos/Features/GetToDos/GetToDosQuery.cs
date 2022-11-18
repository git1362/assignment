using MediatR;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDos
{
    public class GetToDosQuery: IRequest<List<GetToDoDto>>
    {
    }
}
