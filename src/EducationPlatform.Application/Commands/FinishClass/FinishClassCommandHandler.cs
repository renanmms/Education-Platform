using EducationPlatform.Application.Results;
using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Commands.FinishClass
{
    public class FinishClassCommandHandler : IRequestHandler<FinishClassCommand, Guid>
    {
        private readonly IUserRepository _repository;

        public FinishClassCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(FinishClassCommand request, CancellationToken cancellationToken)
        {
            var userClassConcluded = new UserClassConcluded(request.UserId, request.ClassId, request.ConclusionDate, request.Score);
            var id = await _repository.FinishClassAsync(userClassConcluded);

            return id;
        }
    }
}
