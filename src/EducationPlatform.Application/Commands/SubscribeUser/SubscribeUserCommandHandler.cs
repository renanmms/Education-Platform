using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.SubscribeUser
{
    public record SubscribeUserCommandHandler : IRequestHandler<SubscribeUserCommand, Guid>
    {
        private IUserRepository _repository;
        public SubscribeUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(SubscribeUserCommand request, CancellationToken cancellationToken)
        {
            var userSubscription = new UserSubscription(request.UserId,
                request.SubscriptionId,
                request.StartDate,
                request.ExpirationDate);

            var id = await _repository.SubscribeUserAsync(userSubscription);

            return id;
        }
    }
}
