using MediatR;

namespace EducationPlatform.Application.Commands.CreateSubscription
{
    public record CreateSubscriptionCommand(
        string? Name,
        int Duration) : IRequest<Guid>;
}