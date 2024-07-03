using EducationPlatform.Application.Commands.CreateCourse;
using FluentValidation;

namespace EducationPlatform.Application.Validators
{
    public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.SubscriptionId)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.Description)
                .NotNull()
                .MaximumLength(255)
                .WithMessage("Description must have less than 255 characters");
        }
    }
}