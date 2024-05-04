namespace EducationPlatform.Core.Entities
{
    public class Class
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? LinkVideo { get; set; }
        public int Duration { get; set; }
    }
}