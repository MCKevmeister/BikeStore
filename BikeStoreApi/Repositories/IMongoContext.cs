using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IMongoContext : IDisposable
    {
        IMongoDatabase Database { get; }
        IClientSessionHandle Session { get; set; }

        // void Dispose();
        IMongoCollection<T> GetCollection<T>(string name);
        Task<int> SaveChanges();
    }
}