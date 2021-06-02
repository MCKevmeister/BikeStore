using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IMongoCollection<Manufacturer> _manufacturers;

        public ManufacturerService(IMongoContext mongoContext)
        {
            _manufacturers = mongoContext.Database.GetCollection<Manufacturer>(nameof(Manufacturer));
        }

        public ActionResult<List<Manufacturer>> GetAll() =>
            _manufacturers.Find(manufacturer => true).ToList();

        public Task<Manufacturer> Get(ObjectId id) =>
            _manufacturers.Find(manufacturer => manufacturer.Id == id).FirstOrDefaultAsync();

        public Manufacturer Create(Manufacturer manufacturer)
        {
            _manufacturers.InsertOneAsync(manufacturer);
            return manufacturer;
        }

        public Task<ReplaceOneResult> Update(ObjectId id, Manufacturer manufacturerIn) =>
            _manufacturers.ReplaceOneAsync(manufacturer => manufacturer.Id == id, manufacturerIn);

        public Task<DeleteResult> Remove(Manufacturer manufacturerIn) =>
            _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == manufacturerIn.Id);

        public Task<DeleteResult> Remove(ObjectId id) =>
            _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == id);
    }
}