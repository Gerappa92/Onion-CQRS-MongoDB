using Convey.CQRS.Commands;
using Onion_CQRS_MongoDB.Domain.ValueObjects;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Commands
{
    public class CreateSpeciesCommandHandler : ICommandHandler<CreateSpeciesCommand>
    {
        private readonly ISpeciesRepository _repository;

        public CreateSpeciesCommandHandler(ISpeciesRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(CreateSpeciesCommand command)
        {
            var species = new Species(command.Name, command.AnimalClass, command.ConsumeType);
            await _repository.AddSpecies(species);
        }
    }
}
