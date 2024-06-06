using MediatR;

namespace EducationPlatform.Application.Commands.CreateClass
{
    public record CreateClassCommand(
        string? Description,
        string? LinkVideo,
        int Duration,
        Guid ModuleId
    ) : IRequest<Guid>;
}