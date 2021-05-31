using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IMongoCollection<Manufacturer> _manufacturer;

        public ManufacturerService(IBikeStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _manufacturer = database.GetCollection<Manufacturer>(settings.ManufacturerCollectionName);
        }

        public List<Manufacturer> GetAll() =>
            _manufacturer.Find(book => true).ToList();

        public Manufacturer Get(string id) =>
            _manufacturer.Find<Manufacturer>(manufacturer => manufacturer.Id == id).FirstOrDefault();

        public Manufacturer Create(Manufacturer manufacturer)
        {
            _manufacturer.InsertOne(manufacturer);
            return manufacturer;
        }

        public void Update(string id, Manufacturer manufacturerIn) =>
            _manufacturer.ReplaceOne(manufacturer => manufacturer.Id == id, manufacturerIn);

        public void Remove(Manufacturer manufacturerIn) =>
            _manufacturer.DeleteOne(manufacturer => manufacturer.Id == manufacturerIn.Id);

        public void Remove(string id) => 
            _manufacturer.DeleteOne(manufacturer => manufacturer.Id == id);
    }
}