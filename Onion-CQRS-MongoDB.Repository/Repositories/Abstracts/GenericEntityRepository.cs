using Onion_CQRS_MongoDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Abstracts
{
    public abstract class GenericEntityRepository<T> where T : Entity
    {
        private readonly IEntityRepository<T> _repository;

        protected GenericEntityRepository(IEntityRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }
        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
        public async Task<T> GetAsync(Guid id)
        {
            return await GetAsync(id);
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
            return await ExistAsync(query);
        }
    }
}
