using System;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class MongoContext : IMongoContext
    {
        private readonly MongoClient _mongoClient;

        public IMongoDatabase Database { get; }

        public IClientSessionHandle Session { get; set; }

        public MongoContext(IBikeStoreDatabaseSettings configuration)
        {
            _mongoClient = new MongoClient(configuration.ConnectionString);
            Database = _mongoClient.GetDatabase(configuration.DatabaseName);
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