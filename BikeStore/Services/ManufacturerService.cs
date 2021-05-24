using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStore.Server.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IMongoCollection<Manufacturer> _manufacturers;

        public ManufacturerService(IBikeStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _manufacturers = database.GetCollection<Manufacturer>(settings.ManufacturerCollectionName);
        }

        public List<Manufacturer> GetAll() =>
            _manufacturers.Find(manufacturer => true).ToList();

        public Manufacturer Get(string id) =>
            _manufacturers.Find<Manufacturer>(manufacturer => manufacturer.Id == id).FirstOrDefault();

        public Manufacturer Create(Manufacturer manufacturer)
        {
            _manufacturers.InsertOne(manufacturer);
            return manufacturer;
        }

        public void Update(string id, Manufacturer manufacturerIn) =>
            _manufacturers.ReplaceOne(manufacturer => manufacturer.Id == id, manufacturerIn);

        public void Remove(Manufacturer manufacturerIn) =>
            _manufacturers.DeleteOne(manufacturer => manufacturer.Id == manufacturerIn.Id);

        public void Remove(string id) =>
            _manufacturers.DeleteOne(manufacturer => manufacturer.Id == id);
    }
}