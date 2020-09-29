using Onion_CQRS_MongoDB.Domain.Entities;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Entities
{
    public class AnimalRepository : GenericEntityRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(IEntityRepository<Animal> repository) : base(repository)
        {
        }

        public async Task<Guid> AddAnimal(Animal entity)
        {
            return await AddAsync(entity);
        }
    }
}
