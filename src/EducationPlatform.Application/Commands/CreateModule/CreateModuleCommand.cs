using MediatR;

namespace EducationPlatform.Application.Commands.CreateModule
{
    public record CreateModuleCommand(
        string? Name,
        string? Description,
        DateTime CreatedAt,
        Guid CourseId
    ) : IRequest<Guid>;
}