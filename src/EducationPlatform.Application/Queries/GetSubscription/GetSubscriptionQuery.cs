using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetSubscription
{
    public record GetSubscriptionQuery(Guid Id) : IRequest<GetSubscriptionViewModel>;
}