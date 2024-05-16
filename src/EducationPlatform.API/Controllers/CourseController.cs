using EducationPlatform.Application.Commands.CreateCourse;
using EducationPlatform.Application.Queries.GetCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CourseController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetCourseQuery(id);
            var course = await _mediator.Send(query);

            return Ok(course);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateCourseCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }       
    }
}