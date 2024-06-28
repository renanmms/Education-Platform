using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Application.Results;
using EducationPlatform.Application.Results.Errors;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;

namespace EducationPlatform.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserViewModel>>
    {
        private readonly IUserRepository _repository;
        public GetUserQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<GetUserViewModel>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByIdAsync(request.Id);

            if(user is null)
            {
                return Result<GetUserViewModel>.Failure<GetUserViewModel>(UserErrors.UserNotFound);
            }

            var dto = GetUserViewModel.ToDTO(user);
            
            return Result<GetUserViewModel>.Success<GetUserViewModel>(dto);
        }
    }
}