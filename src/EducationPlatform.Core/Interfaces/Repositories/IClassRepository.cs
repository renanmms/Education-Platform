using EducationPlatform.Core.Entities;

namespace EducationPlatform.Core.Interfaces.Repositories
{
    public interface IClassRepository
    {
        Task<Guid> CreateAsync(Classroom myClass);
        Task<Classroom?> GetByIdAsync(Guid id);
    }
}