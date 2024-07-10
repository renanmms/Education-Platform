using EducationPlatform.Core.Enums;

namespace EducationPlatform.Core.Entities
{
    public class User
    {
        public User(string? fullname, string? email, string? password, DateTime birthdate, string? document, string? phone, Role role)
        {
            Fullname = fullname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
            Document = document;
            Phone = phone;
            Role = role;
        }

        public Guid Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Document { get; set; }
        public string? Phone { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; } = [];
        public ICollection<UserClassConcluded> FinishedClasses { get; } = [];
    }
}