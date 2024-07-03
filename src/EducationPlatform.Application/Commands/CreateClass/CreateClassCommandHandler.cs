using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.CreateClass
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, Guid>
    {
        private readonly IClassRepository _repository;
        public CreateClassCommandHandler(IClassRepository repository)
        {
            _repository = repository;    
        }

        public Task<Guid> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var classroom = new Classroom(request.Description, request.LinkVideo, request.Duration, request.ModuleId);
            var id = _repository.CreateAsync(classroom);
            return id;
        }
    }
}