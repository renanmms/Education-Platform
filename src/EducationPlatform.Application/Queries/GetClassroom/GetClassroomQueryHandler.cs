using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetClassroom
{
    public class GetClassroomQueryHandler : IRequestHandler<GetClassroomQuery, GetClassroomViewModel>
    {
        private readonly IClassRepository _repository;
        public GetClassroomQueryHandler(IClassRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetClassroomViewModel> Handle(GetClassroomQuery request, CancellationToken cancellationToken)
        {
            var classroom = await _repository.GetByIdAsync(request.Id);
            return GetClassroomViewModel.ToDTO(classroom);
        }
    }
}