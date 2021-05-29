using System;
using System.Data;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public interface IMongoContext : IDisposable
        {
            Task<int> SaveChanges();
            IMongoDatabase Database { get; }
            IMongoCollection<T> GetCollection<T>(string name);
        }
    }