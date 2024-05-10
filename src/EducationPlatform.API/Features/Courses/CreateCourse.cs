using Carter;
using EducationPlatform.API.Contracts;
using EducationPlatform.API.Entities;
using EducationPlatform.API.Persistence;
using EducationPlatform.API.Shared;
using FluentValidation;
using Mapster;
using MediatR;
using static EducationPlatform.API.Features.Courses.CreateCourse;

namespace EducationPlatform.API.Features.Courses
{
    public class CreateCourseEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("api/courses", async (CreateCourseRequest request, ISender sender) => 
            {
                var command = request.Adapt<Command>();

                var result = await sender.Send(command);
                if(result.IsFailure)
                {
                    return Results.BadRequest(result.Error);
                }

                return Results.Ok(result.Value);
            });
        }
    }

    public static class CreateCourse
    {
        public class Command : IRequest<Result<Guid>>
        {
            public Guid Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string? Cover { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(c => c.Name)
                    .NotNull()
                    .NotEmpty();

                RuleFor(c => c.Description)
                    .NotNull()
                    .NotEmpty();

                RuleFor(c => c.Cover)
                    .NotNull()
                    .NotEmpty();
            }
        }

        internal sealed class Handler : IRequestHandler<Command, Result<Guid>>
        {
            private readonly EducationPlatformDbContext _dbContext;
            private readonly IValidator<Command> _validator;

            public Handler(EducationPlatformDbContext dbContext, IValidator<Command> validator)
            {
                _dbContext = dbContext;
                _validator = validator;
            }

            public async Task<Result<Guid>> Handle(Command request, CancellationToken cancellationToken)
            {
                var validationResult = _validator.Validate(request);
                if(!validationResult.IsValid)
                {
                    return Result<Guid>.Failure(new Error("CreateCourse.Validation", validationResult.ToString()));
                }

                var course = new Course
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    Description = request.Description,
                    Cover = request.Cover,
                    CreatedAt = request.CreatedAt
                };

                _dbContext.Add(course);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return Result<Guid>.Success(request.Id);
            }    
        }
    }
}