using Onion_CQRS_MongoDB.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Abstracts
{
    public abstract class GenericValueObjectRepository<T> where T : ValueObject
    {
        private readonly IValueObjectRepository<T> _repository;

        protected GenericValueObjectRepository(IValueObjectRepository<T> repository)
        {
            _repository = repository;
        }

        protected async Task AddAsync(T valueObject)
        {
            await _repository.AddAsync(valueObject);
        }
        protected async Task UpdateAsync(T valueObject)
        {
            await _repository.UpdateAsync(valueObject);
        }
        protected async Task DeleteAsync(T valueObject)
        {
            await _repository.DeleteAsync(valueObject);
        }
        protected async Task<T> GetAsync(T valueObject)
        {
            return await _repository.GetAsync(valueObject);
        }
        protected async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        protected async Task<IEnumerable<T>> WhereAsync(Func<T, bool> query)
        {
            return await _repository.WhereAsync(query);
        }
        protected async Task<bool> ExistAsync(Func<T, bool> query)
        {
            return await _repository.ExistAsync(query);
        }
    }
}
