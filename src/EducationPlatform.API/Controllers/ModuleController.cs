using System.Runtime.CompilerServices;
using EducationPlatform.Application.Commands.CreateModule;
using EducationPlatform.Application.DTO.InputModels;
using EducationPlatform.Application.Queries.GetModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ModuleController(IMediator mediator)
        {
            _mediator = mediator;    
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetModuleQuery(id);
            var module = await _mediator.Send(query);

            return Ok(module);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateModuleCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }
    }
}