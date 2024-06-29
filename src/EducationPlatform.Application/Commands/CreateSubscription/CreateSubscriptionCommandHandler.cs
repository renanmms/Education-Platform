using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Guid>
    {
        private readonly ISubscriptionRepository _repository;
        public CreateSubscriptionCommandHandler(ISubscriptionRepository repository)
        {
            _repository = repository;    
        }

        public async Task<Guid> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var subscription = new Subscription {
                Name = request.Name,
                Duration = request.Duration
            };

            var id = await _repository.CreateAsync(subscription);

            return id;
        }
    }
}