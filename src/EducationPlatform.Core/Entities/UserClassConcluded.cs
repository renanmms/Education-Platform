namespace EducationPlatform.Core.Entities
{
    public class UserClassConcluded
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClassId { get; set; }
        public DateTime ConclusionDate { get; set; }
        public int Score { get; set; }
        public User? User { get; set; } = null!;
        public Classroom? Class { get; set; } = null!;
    }
}