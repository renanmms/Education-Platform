using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetModule
{
    public class GetModuleQueryHandler : IRequestHandler<GetModuleQuery, GetModuleViewModel>
    {
        private readonly IModuleRepository _repository;
        public GetModuleQueryHandler(IModuleRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetModuleViewModel> Handle(GetModuleQuery request, CancellationToken cancellationToken)
        {
            var model = GetModuleViewModel.ToDTO(await _repository.GetByIdAsync(request.Id));
            return model;
        }
    }
}