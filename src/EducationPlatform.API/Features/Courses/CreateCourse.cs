using EducationPlatform.API.Entities;
using EducationPlatform.API.Persistence;
using EducationPlatform.API.Shared;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Features.Courses
{   
    [ApiController]
    public partial class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateCourse.Command command)
        {
            var result = await _mediator.Send(command);
            if(result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
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