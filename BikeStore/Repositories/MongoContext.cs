using System;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public abstract class MongoContext : IMongoContext
    {
        private IMongoDatabase Database { get; set; }
        private MongoClient MongoClient { get; set; }
        public IClientSessionHandle Session { get; set; }
        public MongoContext(IOptions<IBikeStoreDatabaseSettings> configuration)
        {
            MongoClient = new MongoClient(configuration.Value.ConnectionString);
            Database = MongoClient.GetDatabase(configuration.Value.DatabaseName);
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
