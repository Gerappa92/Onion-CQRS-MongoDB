using MongoDB.Driver;
using Onion_CQRS_MongoDB.Domain.Entities;
using Onion_CQRS_MongoDB.Domain.ValueObjects;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Repository
{
    public class MongoValueObjectRepository<T> : IValueObjectRepository<T> where T : ValueObject
    {
        private IMongoCollection<T> _collection;

        public MongoValueObjectRepository(MongoContext mongoContext)
        {
            var collectionName = typeof(T).Name;
            _collection = mongoContext.Datebase.GetCollection<T>(collectionName);
        }

        public async Task AddAsync(T valueObject)
        {
            await _collection.InsertOneAsync(valueObject);
        }

        public Task DeleteAsync(T valueObject)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(Func<T, bool> query)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(T valueObject)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T valueObject)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> WhereAsync(Func<T, bool> query)
        {
            throw new NotImplementedException();
        }
    }
}
