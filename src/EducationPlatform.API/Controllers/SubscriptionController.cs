using EducationPlatform.Application.Commands.CreateSubscription;
using EducationPlatform.Application.Commands.PaySubscription;
using EducationPlatform.Application.Queries.GetSubscription;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator;    
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetSubscriptionQuery(id);
            var sub = await _mediator.Send(query);

            return Ok(sub);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateSubscriptionCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }

        [HttpPost("payment")]
        public async Task<IActionResult> PaySubscription(PaySubscriptionCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtRoute("User/subscription/", new {id = id});
        }
    }
}