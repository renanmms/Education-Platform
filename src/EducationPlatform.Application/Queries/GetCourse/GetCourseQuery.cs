using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetCourse
{
    public record GetCourseQuery(Guid Id) : IRequest<GetCourseViewModel>;
}