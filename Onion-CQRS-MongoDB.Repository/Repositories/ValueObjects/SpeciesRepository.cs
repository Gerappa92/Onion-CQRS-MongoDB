using Onion_CQRS_MongoDB.Domain.ValueObjects;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;

namespace Onion_CQRS_MongoDB.Repository.Repositories.ValueObjects
{
    public class SpeciesRepository : GenericValueObjectRepository<Species>
    {
        public SpeciesRepository(IValueObjectRepository<Species> repository) : base(repository)
        {
        }
    }
}
