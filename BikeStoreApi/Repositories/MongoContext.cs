using System;
using System.Threading.Tasks;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class MongoContext : IMongoContext
    {
        public IMongoDatabase Database { get; }

        public IClientSessionHandle Session { get; set; }

        public MongoContext(IBikeStoreDatabaseSettings configuration)
        {
            var mongoClient = new MongoClient(configuration.ConnectionString);
            Database = mongoClient.GetDatabase(configuration.DatabaseName);
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return Database.GetCollection<T>(name);
        }
        // https://www.thecodebuzz.com/mongodb-repository-implementation-unit-testing-net-core-example
        // https://bryanavery.co.uk/asp-net-core-mongodb-repository-pattern-unit-of-work/

        public virtual void Dispose()
        {
        }
    }
}