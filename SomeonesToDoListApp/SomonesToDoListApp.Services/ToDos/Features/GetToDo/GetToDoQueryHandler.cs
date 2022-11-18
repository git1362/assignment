using MediatR;
using SomonesToDoListApp.Services.Contracts;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDo
{
    public class GetToDoQueryHandlerpublic : IRequestHandler<GetToDoQuery, GetToDoDto>
    {
        private readonly ITodoRepository _repository;

        public GetToDoQueryHandlerpublic(ITodoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<GetToDoDto> Handle(GetToDoQuery request, CancellationToken cancellationToken)
        {
            var todo = await _repository.GetAsync(request.Id);
            return todo.ToDto();
        }
    }
}
