using EducationPlatform.Core.Entities;

namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetCourseViewModel(Guid Id,
        string? Name, 
        string? Description,
        string? Cover,
        DateTime CreatedAt,
        Guid SubscriptionId) 
        {
            public static GetCourseViewModel ToDTO(Course course)
            {
                return new GetCourseViewModel(
                    course.Id,
                    course.Name,
                    course.Description,
                    course.Cover,
                    course.CreatedAt,
                    course.SubscriptionId);
            }
        };
}