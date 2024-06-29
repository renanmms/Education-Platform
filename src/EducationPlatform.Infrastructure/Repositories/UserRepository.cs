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

            return user.Id;
        }

        public async Task<Guid> FinishClassAsync(UserClassConcluded userClassConcluded)
        {
            await _dbContext.FinishedClasses.AddAsync(userClassConcluded);

            return userClassConcluded.Id;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

            return user;
        }
    }
}