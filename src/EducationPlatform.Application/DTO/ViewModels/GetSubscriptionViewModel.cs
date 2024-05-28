using EducationPlatform.Core.Entities;

namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetSubscriptionViewModel(
        Guid Id,
        string? Name,
        int Duration)
        {
            public static GetSubscriptionViewModel ToDTO(Subscription subscription)
            {
                return new GetSubscriptionViewModel(
                    subscription.Id,
                    subscription.Name,
                    subscription.Duration
                );
            }
        };
}