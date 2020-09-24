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

        public async Task AddAsync(T valueObject)
        {
            await _repository.AddAsync(valueObject);
        }
        public async Task UpdateAsync(T valueObject)
        {
            await _repository.UpdateAsync(valueObject);
        }
        public async Task DeleteAsync(T valueObject)
        {
            await _repository.DeleteAsync(valueObject);
        }
        public async Task<T> GetAsync(T valueObject)
        {
            return await _repository.GetAsync(valueObject);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<IEnumerable<T>> WhereAsync(Func<T, bool> query)
        {
            return await _repository.WhereAsync(query);
        }
        public async Task<bool> ExistAsync(Func<T, bool> query)
        {
            return await _repository.ExistAsync(query);
        }
    }
}
