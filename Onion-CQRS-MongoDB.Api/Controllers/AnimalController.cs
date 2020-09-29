using Microsoft.AspNetCore.Mvc;
using Onion_CQRS_MongoDB.Services.CommandBus;
using Onion_CQRS_MongoDB.Services.Commands;

namespace Onion_CQRS_MongoDB.Api.Controllers
{
    public class AnimalController : MainController
    {
        ICommandBus _commandBus;

        public AnimalController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAnimalCommand command)
        {
            _commandBus.Send(command);
            return Ok();
        }
    }
}
