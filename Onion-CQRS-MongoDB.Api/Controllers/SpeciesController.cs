using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using Onion_CQRS_MongoDB.Services.Commands;
using Onion_CQRS_MongoDB.Services.Queries;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Api.Controllers
{
    public class SpeciesController : MainController
    {
        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        public SpeciesController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAsync()
        {
            var species = await _queryDispatcher.QueryAsync(new GetAllSpeciesQuery());
            return Ok(species);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSpeciesCommand command)
        {
            await _commandDispatcher.SendAsync(command);
            return Ok();
        }
    }
}
