using System;

namespace EducationPlatform.Application.Results.Errors
{
    public static class UserErrors
    {
        public static readonly Error UserNotFound = new("Users.UserNotFound", "User not founded.");
    }
}