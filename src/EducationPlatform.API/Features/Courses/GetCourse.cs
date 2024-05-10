using Carter;
using EducationPlatform.API.Contracts;
using EducationPlatform.API.Persistence;
using EducationPlatform.API.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EducationPlatform.API.Features.Courses
{
    public class GetCourseEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("api/courses/{id}", async (Guid id, ISender sender) => 
            {
                var query = new GetCourse.Query {
                    Id = id
                };

                var result = await sender.Send(query);

                if(result.IsFailure)
                {
                    return Results.NotFound(result.Error);
                }

                return Results.Ok(result.Value);
            });
        }
    }


    public static class GetCourse
    {
        public class Query : IRequest<Result<GetCourseResponse>>
        {
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