using MediatR;
using Microsoft.Extensions.Logging;
using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.Contracts;
using SomonesToDoListApp.Services.ToDos.Exceptions;

namespace SomonesToDoListApp.Services.ToDos.Features.UpdateToDo
{
    public class UpdateToDoCommandHandler : IRequestHandler<UpdateToDoCommand, UpdateToDoCommandResponse>
    {
        private readonly ITodoRepository _repository;

        public UpdateToDoCommandHandler(ITodoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<UpdateToDoCommandResponse> Handle(UpdateToDoCommand request, CancellationToken cancellationToken)
        {
            var updateToDoResponse = new UpdateToDoCommandResponse();

            var validator = new UpdateToDoCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);


            var existingToDoItem = await _repository.GetAsync(request.Id);
            if (existingToDoItem is null)
            {
                throw new NotFoundException(nameof(ToDo), request.Id);
            }

            var entity = request.ToEntity();
            await _repository.UpdateAsync(entity);


            return updateToDoResponse;
        }
    }
}