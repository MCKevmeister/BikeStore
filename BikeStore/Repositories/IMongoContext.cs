using System;
using System.Data;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public interface IMongoContext : IDisposable
        {
            // void AddCommand(Func<Task> func);
            Task<int> SaveChanges();
            //MongoCollectionBase<T> GetCollection<T>(string name);
            IMongoCollection<T> GetCollection<T>(string name);
        }
    }