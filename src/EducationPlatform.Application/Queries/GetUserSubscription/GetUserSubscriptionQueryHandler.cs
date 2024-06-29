using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetUserSubscription
{
    public class GetUserSubscriptionQueryHandler : IRequestHandler<GetUserSubscriptionQuery, GetUserSubscriptionViewModel>
    {
        private readonly IUserRepository _repository;
        public GetUserSubscriptionQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetUserSubscriptionViewModel> Handle(GetUserSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var userSubscription = await _repository.GetUserSubscriptionAsync(request.UserId, request.SubscriptionId);

            return new GetUserSubscriptionViewModel(userSubscription.UserId,
                userSubscription.User.Fullname,
                userSubscription.User.Email,
                userSubscription.SubscriptionId,
                userSubscription.Subscription?.Name,
                userSubscription.StartDate,
                userSubscription.ExpirationDate);
        }
    }
}
