using EducationPlatform.Application.Queries.GetCourse;
using FluentValidation;

namespace EducationPlatform.Application.Validators
{
    public class GetCourseQueryValidator : AbstractValidator<GetCourseQuery>
    {
        public GetCourseQueryValidator()
        {
            RuleFor(c => c.Id)
                .NotNull()
                .NotEmpty();
        }
    }
}