using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class ClassroomConfigurations : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasMany(c => c.FinishedClasses)
                .WithOne(fc => fc.Class)
                .HasForeignKey(fc => fc.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}