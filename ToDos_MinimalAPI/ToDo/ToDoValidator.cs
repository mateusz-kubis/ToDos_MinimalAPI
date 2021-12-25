using FluentValidation;

namespace ToDos_MinimalAPI;

public class ToDoValidator : AbstractValidator<ToDo>
{
    public ToDoValidator()
    {
        RuleFor(x => x.Value)
            .NotEmpty()
            .MinimumLength(5)
            .WithMessage("Value of a todo must be at least 5 characters long");
    }
}
