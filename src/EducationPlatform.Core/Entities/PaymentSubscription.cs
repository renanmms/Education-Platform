using EducationPlatform.Core.Enums;

namespace EducationPlatform.Core.Entities
{
    public class PaymentSubscription
    {
        public PaymentSubscription(DateTime processingDate, Status status, string? message, int value, Guid userSubscriptionId, string? paymentLink, string? externalPaymentId, DateTime expirationDate)
        {
            ProcessingDate = processingDate;
            Status = status;
            Message = message;
            Value = value;
            UserSubscriptionId = userSubscriptionId;
            PaymentLink = paymentLink;
            ExternalPaymentId = externalPaymentId;
            ExpirationDate = expirationDate;
        }

        public Guid Id { get; set; }
        public DateTime ProcessingDate { get; set; }
        public Status Status { get; set; }
        public string? Message { get; set; }
        public int Value { get; set; }
        public Guid UserSubscriptionId { get; set; }
        public string? PaymentLink { get; set; }
        public string? ExternalPaymentId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public UserSubscription? UserSubscription { get; set; }
    }
}