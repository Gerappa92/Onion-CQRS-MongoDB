using Onion_CQRS_MongoDB.Domain.Entities;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using Onion_CQRS_MongoDB.Services.Commands.Abstracts;
using System.Linq;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Commands
{
    public class CreateAnimalCommandHandler : ICommandHandler<CreateAnimalCommand>
    {
        IAnimalRepository _repository;
        ISpeciesRepository _speciesRepository;

        public CreateAnimalCommandHandler(IAnimalRepository repository, ISpeciesRepository speciesRepository)
        {
            _repository = repository;
            _speciesRepository = speciesRepository;
        }

        public async Task HandleAsync(CreateAnimalCommand command)
        {
            var allSpecies = await _speciesRepository.GetAllSpecies();
            var species = allSpecies.FirstOrDefault(x => x.Name == command.Name);
            var animal = new Animal(command.Name, command.Age, command.Gender, species);
            await _repository.AddAnimal(animal);
        }


    }
}
