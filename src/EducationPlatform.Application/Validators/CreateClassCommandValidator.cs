using EducationPlatform.Application.Commands.CreateClass;
using FluentValidation;

namespace EducationPlatform.Application.Validators
{
    public class CreateClassCommandValidator : AbstractValidator<CreateClassCommand>
    {
        public CreateClassCommandValidator()
        {
            RuleFor(c => c.LinkVideo)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.Duration)
                .NotEmpty();

            RuleFor(c => c.ModuleId)
                .NotEmpty();
        }
    }
}