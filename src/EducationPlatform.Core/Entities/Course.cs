namespace EducationPlatform.Core.Entities
{
    public class Course
    {
        public Course(string? name, string? description, string? cover, DateTime createdAt)
        {
            Name = name;
            Description = description;
            Cover = cover;
            CreatedAt = createdAt;
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Cover { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid SubscriptionId { get; set; }
        public Subscription Subscription { get; set; } = null!;
        public List<Module> Modules { get; set; } = [];
    }
}