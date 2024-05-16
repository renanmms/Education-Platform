using System;
using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetCourse
{
    public class GetCourseQueryHandler : IRequestHandler<GetCourseQuery, GetCourseViewModel>
    {
        private readonly ICourseRepository _courseRepository;
        public GetCourseQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<GetCourseViewModel> Handle(GetCourseQuery request, CancellationToken cancellationToken)
        {
            var dto = GetCourseViewModel.ToDTO(await _courseRepository.GetByIdAsync(request.Id));
            return dto;
        }
    }
}