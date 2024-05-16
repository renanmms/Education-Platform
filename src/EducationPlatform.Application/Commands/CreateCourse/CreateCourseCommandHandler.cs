using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepository _repository;
        public CreateCourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository;
        }
    
        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course(request.Name, request.Description, request.Cover, request.CreatedAt);
            var id = await _repository.CreateAsync(course);
            return id;
        }
    }
}