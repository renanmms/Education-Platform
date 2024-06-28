using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Enums;

namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetUserViewModel(
        Guid Id,
        string? Fullname,
        string? Email,
        string? Password,
        DateTime Birthdate,
        string? Document, 
        string? Phone,
        Role Role,
        bool IsActive
    )
    {
        public static GetUserViewModel ToDTO(User user)
        {
            return new GetUserViewModel(
                user.Id, 
                user.Fullname, 
                user.Email,
                user.Password,
                user.Birthdate,
                user.Document,
                user.Phone,
                user.Role,
                user.IsActive);
        }
    };
}