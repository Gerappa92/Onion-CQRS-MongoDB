using Onion_CQRS_MongoDB.Domain.Types;
using Onion_CQRS_MongoDB.Services.Commands.Abstracts;

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
