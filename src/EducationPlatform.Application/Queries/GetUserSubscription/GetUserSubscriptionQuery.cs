using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetUserSubscription
{
    public record GetUserSubscriptionQuery(Guid UserId, Guid SubscriptionId) : IRequest<GetUserSubscriptionViewModel>;
}
