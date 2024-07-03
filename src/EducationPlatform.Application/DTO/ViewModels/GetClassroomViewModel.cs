using EducationPlatform.Core.Entities;

namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetClassroomViewModel(Guid Id,
        Guid ModuleId,
        string? Description,
        string? LinkVideo,
        int Duration
    ){
        public static GetClassroomViewModel ToDTO(Classroom classroom)
        {
            return new GetClassroomViewModel(classroom.Id,
                classroom.ModuleId,
                classroom.Description,
                classroom.LinkVideo,
                classroom.Duration);
        }
    }
}