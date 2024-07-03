using EducationPlatform.Application.Commands.CreateClass;
using EducationPlatform.Application.Queries.GetClassroom;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClassController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetClassroomQuery(id);
            var model = await _mediator.Send(query);
            return Ok(model);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateClassCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }
    }
}