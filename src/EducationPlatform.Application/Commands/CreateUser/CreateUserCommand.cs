using EducationPlatform.Core.Enums;
using MediatR;

namespace EducationPlatform.Application.Commands.CreateUser
{
    public record CreateUserCommand(
        string? Fullname,
        string? Email,
        string? Password,
        DateTime BirthDate,
        string? Document,
        string? Phone,
        Role Role
    ) : IRequest<Guid>;
}