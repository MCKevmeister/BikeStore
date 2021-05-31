using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class BikeService : IBikeService
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
}