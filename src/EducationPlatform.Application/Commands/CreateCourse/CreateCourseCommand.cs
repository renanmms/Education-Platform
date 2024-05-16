using MediatR;

namespace EducationPlatform.Application.Commands.CreateCourse
{
    public record CreateCourseCommand(
        string? Name,
        string? Description,
        string? Cover,
        DateTime CreatedAt) : IRequest<Guid>;
}