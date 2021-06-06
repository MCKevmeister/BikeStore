using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IMongoContext : IDisposable
    {
        IMongoDatabase Database { get; }
        IMongoCollection<T> GetCollection<T>(string name);
        Task AddCommand(Func<Task> func);
        Task<int> CommitChanges();
    }
}