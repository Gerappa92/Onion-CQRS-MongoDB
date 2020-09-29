using Microsoft.AspNetCore.Mvc;
using Onion_CQRS_MongoDB.Services.CommandBus;
using Onion_CQRS_MongoDB.Services.Commands;

namespace Onion_CQRS_MongoDB.Api.Controllers
{
    public class SpeciesController : MainController
    {
        ICommandBus _commandBus;

        public SpeciesController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateSpeciesCommand command)
        {
            _commandBus.Send(command);
            return Ok();
        }
    }
}
