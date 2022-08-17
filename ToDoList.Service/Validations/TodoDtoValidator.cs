using FluentValidation;
using ToDoList.Core.DTOs;

namespace ToDoList.Service.Validations
{
    public class TodoDtoValidator : AbstractValidator<TodoCreateDto>
    {
        public TodoDtoValidator()
        {

            RuleFor(x => x.Title).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Content).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.DuetoDateTime).NotNull().WithMessage("{PropertyName} is required").Must(x=>x.Date>DateTime.Now);
        }


    }
}
