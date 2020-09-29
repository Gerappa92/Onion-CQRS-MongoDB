using MongoDB.Driver;
using Onion_CQRS_MongoDB.Domain.Entities;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Repository
{
    public class MongoEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private IMongoCollection<T> _collection;

        public MongoEntityRepository(MongoContext mongoContext)
        {
            var collectionName = typeof(T).Name;
            _collection = mongoContext.Datebase.GetCollection<T>(collectionName);
        }

        public async Task<Guid> AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _collection.DeleteOneAsync(x => x.Id == id);
        }

        public Task<bool> ExistAsync(Func<T, bool> query)
        {

            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> WhereAsync(Func<T, bool> query)
        {
            throw new NotImplementedException();
        }
    }
}
