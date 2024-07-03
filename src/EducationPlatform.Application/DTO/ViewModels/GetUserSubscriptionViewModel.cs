namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetUserSubscriptionViewModel(
        Guid UserId,
        string? Fullname,
        string? Email,
        Guid SubscriptionId,
        string? SubscriptionName,
        DateTime StartDate,
        DateTime ExpirationDate
    );
}
