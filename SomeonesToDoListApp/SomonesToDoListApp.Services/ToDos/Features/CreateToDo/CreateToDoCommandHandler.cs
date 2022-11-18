using MediatR;
using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.Contracts;
using SomonesToDoListApp.Services.ToDos.Exceptions;
using SomonesToDoListApp.Services.ToDos.Features.GetToDo;

namespace SomonesToDoListApp.Services.ToDos.Features.CreateToDo
{
    public class UpdateToDoCommandHandler : IRequestHandler<CreateToDoCommand, CreateToDoCommandResponse>
    {
        private readonly ITodoRepository _repository;

        public UpdateToDoCommandHandler(ITodoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<CreateToDoCommandResponse> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var createToDoResponse = new CreateToDoCommandResponse();

            var validator = new CreateToDoCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);


            var newToDoItem = request.ToEntity();
            var insertedId = await _repository.CreateAsync(newToDoItem);

            newToDoItem.Id = insertedId;
            createToDoResponse.CreateToDoDto = newToDoItem.ToDto();



            return createToDoResponse;
        }
    }
}