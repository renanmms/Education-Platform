using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetFinishedClass
{
    public record GetFinishedClassQuery(Guid UserId, Guid ClassId) : IRequest<GetFinishedClassViewModel>;
}