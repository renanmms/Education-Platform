using EducationPlatform.Core.Entities;

namespace EducationPlatform.Core.Interfaces.Repositories
{
    public interface ICourseRepository
    {
        Task<Guid> CreateAsync(Course course);
        Task<Course?> GetByIdAsync(Guid id);
    }
}