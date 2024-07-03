using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetSubscription
{
    public class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, GetSubscriptionViewModel>
    {
        private readonly ISubscriptionRepository _repository;
        public GetSubscriptionQueryHandler(ISubscriptionRepository repository)
        {
            _repository = repository;    
        }

        public async Task<GetSubscriptionViewModel> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var sub = await _repository.GetByIdAsync(request.Id);
            var model = GetSubscriptionViewModel.ToDTO(sub);

            return model;
        }
    }
}