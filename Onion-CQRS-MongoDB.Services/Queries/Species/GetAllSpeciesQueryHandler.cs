using Convey.CQRS.Queries;
using Onion_CQRS_MongoDB.Domain.ValueObjects;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Queries
{
    public class GetAllSpeciesQueryHandler : IQueryHandler<GetAllSpeciesQuery, IEnumerable<Species>>
    {
        ISpeciesRepository _repository;

        public GetAllSpeciesQueryHandler(ISpeciesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Species>> HandleAsync(GetAllSpeciesQuery command)
        {
            return await _repository.GetAllSpecies();
        }
    }
}
