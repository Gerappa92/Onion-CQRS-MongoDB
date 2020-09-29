using MongoDB.Driver;

namespace Onion_CQRS_MongoDB.Services.Repository
{
    public class MongoContext
    {
        public IMongoDatabase Datebase { get; }

        public MongoContext(string connectionString, string database)
        {
            var client = new MongoClient(connectionString);
            Datebase = client.GetDatabase(database);
        }
    }
}
