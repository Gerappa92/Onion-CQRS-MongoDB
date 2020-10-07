using Convey.CQRS.Commands;
using Onion_CQRS_MongoDB.Domain.Types;

namespace Onion_CQRS_MongoDB.Services.Commands
{
    public class CreateAnimalCommand : ICommand
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string SpeciesName { get; set; }
    }
}
