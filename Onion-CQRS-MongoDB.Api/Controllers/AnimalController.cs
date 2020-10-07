using Convey.CQRS.Commands;
using Microsoft.AspNetCore.Mvc;
using Onion_CQRS_MongoDB.Services.Commands;

namespace Onion_CQRS_MongoDB.Api.Controllers
{
    public class AnimalController : MainController
    {
        ICommandDispatcher _commandDispatcher;

        public AnimalController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAnimalCommand command)
        {
            _commandDispatcher.SendAsync(command);
            return Ok();
        }
    }
}
