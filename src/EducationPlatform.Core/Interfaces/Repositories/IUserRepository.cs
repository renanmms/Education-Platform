using System;
using EducationPlatform.Core.Entities;

namespace EducationPlatform.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> CreateAsync(User user);
        Task<User?> GetByIdAsync(Guid id);
        Task<Guid> FinishClassAsync(UserClassConcluded userClassConcluded);
        Task<Guid> SubscribeUserAsync(UserSubscription userSubscription);
        Task<UserSubscription?> GetUserSubscriptionAsync(Guid userId, Guid subscriptionId);
    }
}