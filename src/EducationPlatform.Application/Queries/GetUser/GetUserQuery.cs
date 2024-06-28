using EducationPlatform.Application.DTO.ViewModels;
using EducationPlatform.Application.Results;
using MediatR;

namespace EducationPlatform.Application.Queries.GetUser
{
    public record GetUserQuery(Guid Id) : IRequest<Result<GetUserViewModel>>;
    
}