using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.Infrastructure.Persistence
{
    public class EducationPlatformDbContext : DbContext
    {
        public EducationPlatformDbContext(DbContextOptions<EducationPlatformDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}