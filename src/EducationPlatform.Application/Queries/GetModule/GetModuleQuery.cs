using EducationPlatform.Application.DTO.ViewModels;
using MediatR;

namespace EducationPlatform.Application.Queries.GetModule
{
    public record GetModuleQuery(Guid Id) : IRequest<GetModuleViewModel>;
}