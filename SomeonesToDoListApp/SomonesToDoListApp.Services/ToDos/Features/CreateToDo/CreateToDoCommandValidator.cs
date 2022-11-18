using FluentValidation;

namespace SomonesToDoListApp.Services.ToDos.Features.CreateToDo
{
    public class CreateToDoCommandValidator : AbstractValidator<CreateToDoCommand>
    {
        public CreateToDoCommandValidator()
        {
            RuleFor(p => p.ToDoItem)
                .NotEmpty().WithMessage("ToDoItem is required.")
                .NotNull();
        }
    }
}
