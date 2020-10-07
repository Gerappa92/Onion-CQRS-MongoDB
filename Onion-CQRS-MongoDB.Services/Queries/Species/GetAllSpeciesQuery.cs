using Convey.CQRS.Queries;
using Onion_CQRS_MongoDB.Domain.ValueObjects;
using System.Collections.Generic;

namespace Onion_CQRS_MongoDB.Services.Queries
{
    public class GetAllSpeciesQuery : IQuery<IEnumerable<Species>>
    {
    }
}
