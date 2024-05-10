namespace EducationPlatform.API.Contracts
{
    public class CreateCourseRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Cover { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}