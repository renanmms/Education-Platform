using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class UserSubscriptionConfigurations : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder
                .HasOne(us => us.User)
                .WithOne(u => u.UserSubscription)
                .HasForeignKey<UserSubscription>(us => us.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(us => us.Subscription)
                .WithMany(s => s.UserSubscriptions)
                .HasForeignKey(us => us.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(us => us.PaymentSubscription)
                .WithOne(ps => ps.UserSubscription)
                .HasForeignKey<PaymentSubscription>(ps => ps.UserSubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}