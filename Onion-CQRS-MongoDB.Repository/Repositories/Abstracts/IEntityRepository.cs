using Onion_CQRS_MongoDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Abstracts
{
    public interface IEntityRepository<T> where T : Entity
    {
        Task<Guid> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> WhereAsync(Func<T, bool> query);
        Task<bool> ExistAsync(Func<T, bool> query);
    }
}
