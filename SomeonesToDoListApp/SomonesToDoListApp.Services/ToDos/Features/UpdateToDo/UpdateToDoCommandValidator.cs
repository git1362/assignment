using FluentValidation;

namespace SomonesToDoListApp.Services.ToDos.Features.UpdateToDo
{
    public class UpdateToDoCommandValidator : AbstractValidator<UpdateToDoCommand>
    {
        public UpdateToDoCommandValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Id is required.")
                .NotNull();

            RuleFor(p => p.ToDoItem)
                .NotEmpty().WithMessage("ToDoItem is required.")
                .NotNull();
        }
    }
}
