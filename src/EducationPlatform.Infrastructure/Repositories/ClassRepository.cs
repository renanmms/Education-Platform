using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly EducationPlatformDbContext _dbContext;
        public ClassRepository(EducationPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> CreateAsync(Classroom myClass)
        {
            await _dbContext.Classes.AddAsync(myClass);
            await _dbContext.SaveChangesAsync();
            return myClass.Id;
        }

        // TODO: Adjust possible null references
        public async Task<Classroom?> GetByIdAsync(Guid id)
        {
            var classroom = await _dbContext.Classes.SingleOrDefaultAsync(c => c.Id == id);
            return classroom;
        }
    }
}