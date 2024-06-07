using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly EducationPlatformDbContext _dbContext;
        public SubscriptionRepository(EducationPlatformDbContext dbContext)
        {
            _dbContext = dbContext;    
        }
        
        public async Task<Guid> CreateAsync(Subscription subscription)
        {
            await _dbContext.Subscriptions.AddAsync(subscription);
            await _dbContext.SaveChangesAsync();
            return subscription.Id;
        }

        public async Task<Subscription?> GetByIdAsync(Guid id)
        {
            var sub =  await _dbContext.Subscriptions.SingleOrDefaultAsync(s => s.Id == id);
            return sub;
        }
    }
}