namespace EducationPlatform.Application.DTO.ViewModels
{
    public record GetModuleViewModel(
        Guid Id,
        string? Name,
        string? Description,
        DateTime CreatedAt
    )
    {
        public static GetModuleViewModel ToDTO(Core.Entities.Module module)
        {
            return new GetModuleViewModel(module.Id, module.Name, module.Description, module.CreatedAt);
        }
    };
}