namespace EducationPlatform.Core.Entities
{
    public class Module
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public List<Class> Classes { get; set; } = [];
    }
}