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
                .HasForeignKey<UserSubscription>(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.UserClassConcluded)
                .WithOne(uc => uc.User)
                .HasForeignKey<UserClassConcluded>(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}