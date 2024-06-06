using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetClassroom
{
    public record GetClassroomQuery(Guid Id) : IRequest<GetClassroomViewModel>;
}