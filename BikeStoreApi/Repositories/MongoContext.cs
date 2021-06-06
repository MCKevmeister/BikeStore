using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class MongoContext : IMongoContext
    {
        private IClientSessionHandle Session { get; set; }
        public IMongoDatabase Database { get; set; }
        private IMongoClient MongoClient { get; set; }
        private readonly List<Func<Task>> _commands;
        
        public MongoContext(IBikeStoreDatabaseSettings configuration)
        {
            _commands = new List<Func<Task>>();
            var mongoClient = new MongoClient(configuration.ConnectionString);
            Database = mongoClient.GetDatabase(configuration.DatabaseName);
        }
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return Database.GetCollection<T>(name);
        }
        public Task AddCommand(Func<Task> func)
        {
            _commands.Add(func);
            return Task.CompletedTask;
        }
        public async Task<int> CommitChanges()
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