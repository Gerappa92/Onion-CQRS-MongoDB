using Onion_CQRS_MongoDB.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Repository.Repositories.Abstracts
{
    public interface IValueObjectRepository<T> where T : ValueObject
    {
        Task AddAsync(T valueObject);
        Task UpdateAsync(T valueObject);
        Task DeleteAsync(T valueObject);
        Task<T> GetAsync(T valueObject);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> WhereAsync(Func<T, bool> query);
        Task<bool> ExistAsync(Func<T, bool> query);
    }
}
