namespace EducationPlatform.Core.Entities
{
    public class Classroom
    {
        public Classroom(string? description, string? linkVideo, int duration, Guid moduleId)
        {
            Description = description;
            LinkVideo = linkVideo;
            Duration = duration;
            ModuleId = moduleId;
        }

        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? LinkVideo { get; set; }
        public int Duration { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; } = null!;
        public UserClassConcluded? UserClassConcluded { get; set; }
    }
}