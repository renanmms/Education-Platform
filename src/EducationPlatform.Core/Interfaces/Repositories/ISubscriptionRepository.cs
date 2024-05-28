using EducationPlatform.Core.Entities;

namespace EducationPlatform.Core.Interfaces.Repositories
{
    public interface ISubscriptionRepository
    {
        Task<Guid> CreateAsync(Subscription subscription);
        Task<Subscription> GetByIdAsync(Guid id);
    }
}