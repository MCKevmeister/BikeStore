using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class BikeService : IBikeService
    {
        private readonly IMongoCollection<Bike> _bikes;
        private IMongoContext Context { get; }

        public BikeService(IMongoContext mongoContext)// /*IBikeStoreDatabaseSettings settings*/)
        {
            Context = mongoContext;
            _bikes = mongoContext.Database.GetCollection<Bike>(nameof(Bike));
            // var client = new MongoClient(settings.ConnectionString);
            // var database = client.GetDatabase(settings.DatabaseName);
            // _bikes = database.GetCollection<Bike>(settings.BikeCollectionName);
        }

        public ActionResult<List<Bike>> Get() =>
            _bikes.Find(bike => true).ToList();

        public Task<Bike> Get(string id) =>
            _bikes.Find(bike => bike.Id == id).FirstOrDefaultAsync();

        public Bike Create(Bike bike)
        {
            _bikes.InsertOne(bike);
            return bike;
        }

        public void Update(string id, Bike bikeIn) =>
            _bikes.ReplaceOne(bike => bike.Id == id, bikeIn);

        public Task<DeleteResult> Remove(Bike bikeIn) =>
            _bikes.DeleteOneAsync(bike => bike.Id == bikeIn.Id);

        public Task<DeleteResult> Remove(string id) => 
            _bikes.DeleteOneAsync(bike => bike.Id == id);
    }
}



/*using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Driver;
using Server.Models;

namespace BikeStore.Server.Services
{
    public class OLDBikeService : IBikeService
    {
        private readonly IMongoCollection<Bike> _bikes;

        public BikeService(IBikeStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _bikes = database.GetCollection<Bike>(settings.BikeCollectionName);
        }

        public List<Bike> Get() =>
            _bikes.Find(bike => true).ToList();

        public Bike Get(string id) =>
            _bikes.Find<Bike>(bike => bike.Id == id).FirstOrDefault();

        public Bike Create(Bike bike)
        {
            _bikes.InsertOne(bike);
            return bike;
        }

        public void Update(string id, Bike bikeIn) =>
            _bikes.ReplaceOne(bike => bike.Id == id, bikeIn);

        public void Remove(Bike bikeIn) =>
            _bikes.DeleteOne(bike => bike.Id == bikeIn.Id);

        public void Remove(string id) =>
            _bikes.DeleteOne(bike => bike.Id == id);
    }
}*/