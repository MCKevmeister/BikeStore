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

        public IMongoCollection<T> GetCollection<T>(string name) =>
            Database.GetCollection<T>(name);
        
        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}