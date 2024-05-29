using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.CreateModule
{
    public class CreateModuleCommandHandler : IRequestHandler<CreateModuleCommand, Guid>
    {
        private readonly IModuleRepository _repository;
        public CreateModuleCommandHandler(IModuleRepository repository)
        {
            _repository = repository;    
        }

        public Task<Guid> Handle(CreateModuleCommand request, CancellationToken cancellationToken)
        {
            var module = new Core.Entities.Module(request.Name, request.Description, request.CreatedAt, request.CourseId);
            var id = _repository.CreateAsync(module);

            return id;
        }
    }
}