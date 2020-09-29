using Onion_CQRS_MongoDB.Domain.ValueObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Interfaces
{
    public interface ISpeciesRepository
    {
        Task AddSpecies(Species entity);
        Task<IEnumerable<Species>> GetAllSpecies();
    }
}
