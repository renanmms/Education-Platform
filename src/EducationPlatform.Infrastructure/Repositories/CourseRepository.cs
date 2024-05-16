using System;
using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EducationPlatformDbContext _dbContext;
        public CourseRepository(EducationPlatformDbContext dbContext)
        {
            _dbContext = dbContext;    
        }

        public async Task<Guid> CreateAsync(Course course)
        {
            await _dbContext.Courses.AddAsync(course);
            await _dbContext.SaveChangesAsync();
            return course.Id;
        }

        public async Task<Course?> GetByIdAsync(Guid id)
        {
            var course = await _dbContext.Courses.SingleOrDefaultAsync(c => c.Id == id);
            return course;
        }
    }
}