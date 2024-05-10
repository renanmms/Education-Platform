using EducationPlatform.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.API.Persistence
{
    public class EducationPlatformDbContext : DbContext
    {
        public EducationPlatformDbContext(DbContextOptions<EducationPlatformDbContext> options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}