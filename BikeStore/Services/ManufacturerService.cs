using System.Collections.Generic;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using MongoDB.Driver;

namespace BikeStore.Server.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IMongoCollection<Manufacturer> _manufacturers;
        private IMongoContext Context { get; }

        public ManufacturerService(IMongoContext mongoContext)
        {
            Context = mongoContext;
            _manufacturers = Context.Database.GetCollection<Manufacturer>((nameof(Manufacturer) + "s").ToLower());
        }

        public List<Manufacturer> GetAll() =>
            _manufacturers.Find(manufacturer => true).ToList();

        public Manufacturer Get(string id) =>
            _manufacturers.Find(manufacturer => manufacturer.Id == id).FirstOrDefault();

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