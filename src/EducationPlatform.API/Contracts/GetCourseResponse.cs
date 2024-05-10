namespace EducationPlatform.API.Contracts
{
    public class GetCourseResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}