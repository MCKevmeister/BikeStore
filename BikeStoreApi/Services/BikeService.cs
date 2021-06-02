using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class BikeService : IBikeService
    {
        private readonly IMongoCollection<Bike> _bikes;
        private IMongoContext Context { get; }

        public BikeService(IMongoContext mongoContext)
        {
            Context = mongoContext;
            _bikes = mongoContext.Database.GetCollection<Bike>(nameof(Bike));
        }

        public ActionResult<List<Bike>> Get() =>
            _bikes.Find(bike => true).ToList();

        public Task<Bike> Get(ObjectId id) =>
            _bikes.Find(bike => bike.Id == id).FirstOrDefaultAsync();

        public Bike Create(Bike bike)
        {
            _bikes.InsertOne(bike);
            return bike;
        }
        
        public void Update(ObjectId id, Bike bikeIn) =>
            _bikes.ReplaceOne(bike => bike.Id == id, bikeIn);

        public Task<DeleteResult> Remove(Bike bikeIn) =>
            _bikes.DeleteOneAsync(bike => bike.Id == bikeIn.Id);

        public Task<DeleteResult> Remove(ObjectId id) => 
            _bikes.DeleteOneAsync(bike => bike.Id == id);
    }
}