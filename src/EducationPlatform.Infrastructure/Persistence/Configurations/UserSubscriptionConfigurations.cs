using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class UserSubscriptionConfigurations : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder.HasOne(us => us.Subscription)
                .WithOne(s => s.UserSubscription)
                .HasForeignKey<UserSubscription>(us => us.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(us => us.PaymentSubscription)
                .WithOne(ps => ps.UserSubscription)
                .HasForeignKey<UserSubscription>(us => us.PaymentSubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}