using MediatR;

namespace EducationPlatform.Application.Commands.FinishClass
{
    public record FinishClassCommand(
        Guid UserId,
        Guid ClassId,
        DateTime ConclusionDate,
        int Score): IRequest<Guid>; 
}
