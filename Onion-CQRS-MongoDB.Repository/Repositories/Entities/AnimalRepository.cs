using Onion_CQRS_MongoDB.Domain.Entities;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Entities
{
    public class AnimalRepository : GenericEntityRepository<Animal>
    {
        public AnimalRepository(IEntityRepository<Animal> repository) : base(repository)
        {
        }
    }
}
