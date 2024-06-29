using EducationPlatform.Core.Enums;
using MediatR;

namespace EducationPlatform.Application.Commands.PaySubscription
{
    public record PaySubscriptionCommand(
        DateTime ProcessingDate,
        Status Status,
        string? Message,
        int Value,
        Guid UserSubscriptionId,
        string? PaymentLink,
        string? ExternalPaymentId,
        DateTime ExpirationDate
    ) : IRequest<Guid>;
}
