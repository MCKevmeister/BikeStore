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
            _manufacturers = mongoContext.GetCollection<Manufacturer>(nameof(Manufacturer));
        }

        public async Task<ActionResult<List<Manufacturer>>> GetAll() =>
            await _manufacturers.Find(manufacturer => true).ToListAsync();

        public async Task<Manufacturer> Get(ObjectId id) =>
            await _manufacturers.Find(manufacturer => manufacturer.Id == id).FirstOrDefaultAsync();

        public async Task<Manufacturer> Create(Manufacturer manufacturer)
        {
            await _manufacturers.InsertOneAsync(manufacturer);
            return manufacturer;
        }

        public async Task<ReplaceOneResult> Update(ObjectId id, Manufacturer manufacturerIn) =>
            await _manufacturers.ReplaceOneAsync(manufacturer => manufacturer.Id == id, manufacturerIn);

        public async Task<DeleteResult> Remove(Manufacturer manufacturerIn) =>
            await _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == manufacturerIn.Id);

        public async Task<DeleteResult> Remove(ObjectId id) =>
            await _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == id);
    }
}