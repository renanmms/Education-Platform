using EducationPlatform.API.Contracts;
using EducationPlatform.API.Persistence;
using EducationPlatform.API.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.API.Features.Courses
{
    public partial class CourseController : ControllerBase 
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCourse.Query(id);
            var result = await _mediator.Send(query);
            if(result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            
            return Ok(result.Value);
        }
    }

    public static class GetCourse
    {
        public class Query : IRequest<Result<GetCourseResponse>>
        {
            public Query(Guid id)
            {
                Id = id;
            }

            public Guid Id { get; set; }
        }

        internal sealed class Handler : IRequestHandler<Query, Result<GetCourseResponse>>
        {
            private readonly EducationPlatformDbContext _dbContext;
            public Handler(EducationPlatformDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<Result<GetCourseResponse>> Handle(Query request, CancellationToken cancellationToken)
            {
                var courseResponse = await _dbContext
                    .Courses
                    .Where(c => c.Id == request.Id)
                    .Select(c => new GetCourseResponse{
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description
                    })
                    .FirstOrDefaultAsync(cancellationToken);

                if(courseResponse is null)
                {
                    return Result<GetCourseResponse>.Failure(new Error("GetCourse.Null", "The course with the specified ID was not found"));
                }

                return Result<GetCourseResponse>.Success(courseResponse);
            }
        }
    }
}