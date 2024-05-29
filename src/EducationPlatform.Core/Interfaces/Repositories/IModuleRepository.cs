using EducationPlatform.Core.Entities;

namespace EducationPlatform.Core.Interfaces.Repositories
{
    public interface IModuleRepository
    {
        Task<Guid> CreateAsync(Module module);
        Task<Module> GetByIdAsync(Guid id);
    }
}