using EducationPlatform.Application.Commands.CreateCourse;
using EducationPlatform.Application.Queries.GetCourse;
using EducationPlatform.Application.Validators;
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
            var validator = new GetCourseQueryValidator();
            var validationResult = validator.Validate(query);

            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString("~"));
            }

            var result = await _mediator.Send(query);

            if(result.IsSuccess)
            {
                return Ok(result.Value);
            }

            return BadRequest(result.Error);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateCourseCommand command)
        {
            var validator = new CreateCourseCommandValidator();
            var validationResult = validator.Validate(command);

            if(!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString("~"));
            }

            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }       
    }
}