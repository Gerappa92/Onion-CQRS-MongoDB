using Onion_CQRS_MongoDB.Domain.ValueObjects;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.ValueObjects
{
    public class SpeciesRepository : GenericValueObjectRepository<Species> , ISpeciesRepository
    {
        public SpeciesRepository(IValueObjectRepository<Species> repository) : base(repository)
        {
        }

        public async Task AddSpecies(Species entity)
        {
            await AddAsync(entity);
        }

        public async Task<IEnumerable<Species>> GetAllSpecies()
        {
            return await GetAllAsync();
        }
    }
}
