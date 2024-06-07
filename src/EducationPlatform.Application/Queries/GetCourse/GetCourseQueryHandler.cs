using System;
using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Application.Results;
using EducationPlatform.Application.Results.Errors;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetCourse
{
    public class GetCourseQueryHandler : IRequestHandler<GetCourseQuery, Result<GetCourseViewModel>>
    {
        private readonly ICourseRepository _courseRepository;
        public GetCourseQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Result<GetCourseViewModel>> Handle(GetCourseQuery request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetByIdAsync(request.Id);
            if(course == null)
            {
                return Result<GetCourseViewModel>.Failure<GetCourseViewModel>(CourseErrors.CourseNotFound);
            }

            var dto = GetCourseViewModel.ToDTO(course);

            return Result<GetCourseViewModel>.Success<GetCourseViewModel>(dto);
        }
    }
}