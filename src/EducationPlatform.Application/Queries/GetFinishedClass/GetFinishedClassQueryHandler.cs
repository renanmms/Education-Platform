using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetFinishedClass
{
    public class GetFinishedClassQueryHandler : IRequestHandler<GetFinishedClassQuery, GetFinishedClassViewModel>
    {
        private readonly IUserRepository _repository;
        public GetFinishedClassQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetFinishedClassViewModel> Handle(GetFinishedClassQuery request, CancellationToken cancellationToken)
        {
            var finishedClass = await _repository.GetFinishedClassAsync(request.UserId, request.ClassId);

            var model = new GetFinishedClassViewModel(
                finishedClass.Class.Module.Description, 
                finishedClass.Class.Module.Course.Description,
                finishedClass.Class.Description,
                finishedClass.User.Fullname,
                finishedClass.User.Email,
                finishedClass.Score,
                finishedClass.ConclusionDate);

            return model;
        }
    }
}