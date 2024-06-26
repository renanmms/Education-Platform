using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasOne(u => u.UserSubscription)
                .WithOne(us => us.User)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.UserClassConcluded)
                .WithOne(uc => uc.User)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}