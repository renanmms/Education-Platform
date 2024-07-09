using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EducationPlatformDbContext _dbContext;
        public UserRepository(EducationPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> CreateAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<Guid> FinishClassAsync(UserClassConcluded userClassConcluded)
        {
            await _dbContext.FinishedClasses.AddAsync(userClassConcluded);
            await _dbContext.SaveChangesAsync();

            return userClassConcluded.Id;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<UserClassConcluded?> GetFinishedClassAsync(Guid userId, Guid classId)
        {
            var finishedClass = await _dbContext.FinishedClasses
                .Include(c => c.Class)
                    .ThenInclude(c => c.Module)
                        .ThenInclude(m => m.Course)
                .Include(c => c.User)
                .SingleOrDefaultAsync(c => c.ClassId == classId && c.UserId == userId);

            return finishedClass;
        }

        public async Task<UserSubscription?> GetUserSubscriptionAsync(Guid userId, Guid subscriptionId)
        {
            var userSubscription = await _dbContext.UserSubscriptions
                .Include(us => us.User)
                .Include(us => us.Subscription)
                .SingleOrDefaultAsync(us => us.UserId == userId && us.SubscriptionId == subscriptionId);

            return userSubscription;
        }

        public async Task<Guid> SubscribeUserAsync(UserSubscription userSubscription)
        {
            await _dbContext.UserSubscriptions.AddAsync(userSubscription);
            await _dbContext.SaveChangesAsync();

            return userSubscription.Id;
        }
    }
}