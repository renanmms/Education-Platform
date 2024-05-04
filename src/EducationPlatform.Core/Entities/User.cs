using EducationPlatform.Core.Enums;

namespace EducationPlatform.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Document { get; set; }
        public string? Cellphone { get; set; }
        public Role Role { get; set; }
    }
}