using Onion_CQRS_MongoDB.Domain.Entities;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Interfaces
{
    public interface IAnimalRepository
    {
        public Task<Guid> AddAnimal(Animal entity);
    }
}
