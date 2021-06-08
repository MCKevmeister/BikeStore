using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly IMongoCollection<Manufacturer> _collection;
        private readonly IMongoContext _mongoContext;
        public ManufacturerRepository(IMongoContext context)
        {
            _mongoContext = context;
            _collection = context.GetCollection<Manufacturer>(nameof(Manufacturer));
        }

        public async Task<Manufacturer> Create(Manufacturer manufacturer)
        {
            await _collection.InsertOneAsync(manufacturer);
            var createdManufacturer = await Get(manufacturer.Name);
            return createdManufacturer;
        }

        public async Task<Manufacturer> Get(string name)
        {
            var filter = Builders<Manufacturer>.Filter.Eq("name", name);
            return await _collection.FindAsync<Manufacturer>(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            var manufacturers = await _collection.Find(Builders<Manufacturer>.Filter.Empty).ToListAsync();
            return manufacturers;
        }
        public async Task Update(Manufacturer entity)
        {
            /*try
            {
                var filter = Builders<Manufacturer>.Filter.Eq("name", updateManufacturer.OldManufacturer.Name);
                var update = Builders<Manufacturer>.Update.Set(m => m.Name, updateManufacturer.NewManufacturer.Name);
                var updateOptions =  new UpdateOptions { IsUpsert = false};
                var updatedResult = await _collection.UpdateOneAsync(filter, update, updateOptions);
                
                return updatedResult.MatchedCount == 0
                    ? new ManufacturerResponse(false, "No manufacturer found with those details")
                    : new ManufacturerResponse(true, updatedResult.IsAcknowledged.ToString());
            }
            catch (Exception e)
            {
                return new ManufacturerResponse(false, e.Message);
            }*/
        }
        public async Task Delete(Manufacturer manufacturer)
        {
            await _collection.DeleteOneAsync(Builders<Manufacturer>.Filter.Where(m => m.Id == manufacturer.Id));
        }

        public void Dispose()
        {
            _mongoContext?.Dispose();
        }
    }
}