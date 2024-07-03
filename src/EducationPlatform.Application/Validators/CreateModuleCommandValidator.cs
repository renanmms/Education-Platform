using EducationPlatform.Application.Commands.CreateModule;
using FluentValidation;

namespace EducationPlatform.Application.Validators
{
    public class CreateModuleCommandValidator : AbstractValidator<CreateModuleCommand>
    {
        public CreateModuleCommandValidator()
        {
            RuleFor(m => m.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(m => m.CourseId)
                .NotEmpty();
        }
    }
}