using EducationPlatform.Application.Commands.CreateSubscription;
using FluentValidation;

namespace EducationPlatform.Application.Validators
{
    public class CreateSubscriptionCommandValidator : AbstractValidator<CreateSubscriptionCommand>
    {
        public CreateSubscriptionCommandValidator()
        {
            RuleFor(s => s.Name)
                .NotNull()
                .NotEmpty();
        }
    }
}