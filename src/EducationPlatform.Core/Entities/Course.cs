namespace EducationPlatform.Core.Entities
{
    public class Course
    {
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