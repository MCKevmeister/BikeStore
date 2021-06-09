using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class MongoContext : IMongoContext
    {
        private IClientSessionHandle Session { get; set; }
        private IMongoDatabase Database { get; set; }
        private IMongoClient MongoClient { get; set; }
        private readonly List<Func<Task>> _commands;
        
        public MongoContext(IBikeStoreDatabaseSettings configuration)
        {
            _commands = new List<Func<Task>>();
            MongoClient = new MongoClient(configuration.ConnectionString);
            Database = MongoClient.GetDatabase(configuration.DatabaseName);
        }
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return Database.GetCollection<T>(name);
        }

        public void AddCommand(Func<Task> func)
        {
            _commands.Add(func);
        }

        public async Task<int> SaveChanges()
        {
            using (Session = await MongoClient.StartSessionAsync())
            {
                Session.StartTransaction();
                var commandTasks = _commands.Select(c => c());
                await Task.WhenAll(commandTasks);
                await Session.CommitTransactionAsync();
            }

            return _commands.Count;
        }
        public void Dispose()
        {
            Session?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}