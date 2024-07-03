using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Application.Results;
using MediatR;

namespace EducationPlatform.Application.Queries.GetCourse
{
    public record GetCourseQuery(Guid Id) : IRequest<Result<GetCourseViewModel>>;
}