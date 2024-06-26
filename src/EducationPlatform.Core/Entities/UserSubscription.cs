namespace EducationPlatform.Core.Entities
{
    public class UserSubscription
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Subscription? Subscription { get; set; }
        public PaymentSubscription? PaymentSubscription { get; set; }
        public User User { get; set; } = null!;
    }
}