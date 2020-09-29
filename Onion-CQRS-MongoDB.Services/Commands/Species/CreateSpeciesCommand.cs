using Onion_CQRS_MongoDB.Domain.Types;
using Onion_CQRS_MongoDB.Services.Commands.Abstracts;

namespace Onion_CQRS_MongoDB.Services.Commands
{
    public class CreateSpeciesCommand : ICommand
    {
        public string Name { get; set; }
        public AnimalClass AnimalClass { get; set; }
        public ConsumeType ConsumeType { get; set; }
    }
}
