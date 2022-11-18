using MediatR;
using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.Contracts;
using SomonesToDoListApp.Services.ToDos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDos
{
    public class GetToDosQueryHandlerpublic : IRequestHandler<GetToDosQuery, List<GetToDoDto>>
    {
        private readonly ITodoRepository _repository;

        public GetToDosQueryHandlerpublic(ITodoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<GetToDoDto>> Handle(GetToDosQuery request, CancellationToken cancellationToken)
        {
            var todos = (await _repository.GetListAsync());
            return todos.Select(t => t.ToDto()).ToList();
        }
    }
}
