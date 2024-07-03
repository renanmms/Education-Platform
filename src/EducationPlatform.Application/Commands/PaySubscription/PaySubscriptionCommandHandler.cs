using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.PaySubscription
{
    public class PaySubscriptionCommandHandler : IRequestHandler<PaySubscriptionCommand, Guid>
    {
        private readonly ISubscriptionRepository _repository;
        public PaySubscriptionCommandHandler(ISubscriptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(PaySubscriptionCommand request, CancellationToken cancellationToken)
        {
            var payment = new PaymentSubscription(request.ProcessingDate, request.Status, request.Message, request.Value, request.UserSubscriptionId, request.PaymentLink, request.ExternalPaymentId, request.ExpirationDate);

            var id = await _repository.PaySubscritionAsync(payment);

            return id;
        }
    }
}
