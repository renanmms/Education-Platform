namespace EducationPlatform.Core.Entities
{
    public class UserClassConcluded
    {
        public UserClassConcluded(Guid userId, Guid classId, DateTime conclusionDate, int score)
        {
            UserId = userId;
            ClassId = classId;
            ConclusionDate = conclusionDate;
            Score = score;
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClassId { get; set; }
        public DateTime ConclusionDate { get; set; }
        public int Score { get; set; }
        public User? User { get; set; } = null!;
        public Classroom? Class { get; set; } = null!;
    }
}