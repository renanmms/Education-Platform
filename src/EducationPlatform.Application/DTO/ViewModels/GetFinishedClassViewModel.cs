namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetFinishedClassViewModel(
        string? ModuleName,
        string? CourseDescription,
        string? ClassDescription,
        string? UserFullname, 
        string? UserEmail,
        int Score,
        DateTime ConclusionDate);
}