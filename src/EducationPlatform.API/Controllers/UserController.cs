using EducationPlatform.Application.Commands.CreateUser;
using EducationPlatform.Application.Queries.GetUser;
using EducationPlatform.Application.Queries.GetUserSubscription;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetUserQuery(id);

            var result = await _mediator.Send(query);

            if(result.IsSuccess)
            {
                return Ok(result.Value);
            }

            return BadRequest(result.Error);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var id = await _mediator.Send(command);
            
            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }

        // TODO: Create two endpoints one for user subscription and other for user class concluded
        [HttpGet("subscription/{id}")]
        public async Task<IActionResult> GetSubscription(Guid userId, Guid subscriptionId)
        {
            var query = new GetUserSubscriptionQuery(userId, subscriptionId);

            var model = await _mediator.Send(query);

            return Ok(model);
        }
    }
}