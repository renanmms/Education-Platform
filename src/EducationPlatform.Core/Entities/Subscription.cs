namespace EducationPlatform.Core.Entities
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        List<Course>? Courses { get; set; }
    }
}