using MediatR;

namespace EducationPlatform.Application.Commands.SubscribeUser
{
    public record SubscribeUserCommand(
        Guid UserId,
        Guid SubscriptionId,
        DateTime StartDate,
        DateTime ExpirationDate
    ) : IRequest<Guid>;
}
