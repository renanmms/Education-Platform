using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasOne(c => c.Subscription)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SubscriptionId);

            builder
                .HasMany(c => c.Modules)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId)
                .IsRequired();
        }
    }
}