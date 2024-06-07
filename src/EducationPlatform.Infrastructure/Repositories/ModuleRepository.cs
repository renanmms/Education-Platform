using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly EducationPlatformDbContext _dbContext;
        public ModuleRepository(EducationPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> CreateAsync(Module module)
        {
            await _dbContext.Modules.AddAsync(module);
            await _dbContext.SaveChangesAsync();
            return module.Id;
        }

        public async Task<Module?> GetByIdAsync(Guid id)
        {
            var module = await _dbContext.Modules.SingleOrDefaultAsync(m => m.Id == id);
            return module;
        }
    }
}