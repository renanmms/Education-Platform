namespace EducationPlatform.Core.Entities
{
    public class UserSubscription
    {
        public UserSubscription(Guid userId, Guid subscriptionId, DateTime startDate, DateTime expirationDate)
        {
            UserId = userId;
            SubscriptionId = subscriptionId;
            StartDate = startDate;
            ExpirationDate = expirationDate;
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public Guid PaymentSubscriptionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public User User { get; set; } = null!;
        public Subscription? Subscription { get; set; }
        public PaymentSubscription? PaymentSubscription { get; set; }
    }
}