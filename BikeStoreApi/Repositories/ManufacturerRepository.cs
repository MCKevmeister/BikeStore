using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        }

        public async Task<Manufacturer> Create(string manufacturerName ,CancellationToken cancellationToken)
        {
            var newManufacturer = new Manufacturer(manufacturerName);
            await Collection.InsertOneAsync(newManufacturer, null, cancellationToken);
            var manufacturer = await GetByName(newManufacturer.Name);
            return manufacturer;
        }

        public async Task<Manufacturer> GetByName(string name)
        {
            var filter = Builders<Manufacturer>.Filter.Eq("name", name);
            return await Collection.FindAsync<Manufacturer>(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            var manufacturers = await Collection.Find(Builders<Manufacturer>.Filter.Empty).ToListAsync();
            return manufacturers;
        }

        public async Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer, CancellationToken cancellationToken = default)
        {
            try
            {
                var filter = Builders<Manufacturer>.Filter.Eq("name", updateManufacturer.OldManufacturer.Name);
                var update = Builders<Manufacturer>.Update.Set(m => m.Name, updateManufacturer.NewManufacturer.Name);
                var updateOptions =  new UpdateOptions { IsUpsert = false};
                var updatedResult = await Collection.UpdateOneAsync(filter, update, updateOptions, cancellationToken);
                
                return updatedResult.MatchedCount == 0
                    ? new ManufacturerResponse(false, "No manufacturer found with those details")
                    : new ManufacturerResponse(true, updatedResult.IsAcknowledged.ToString());
            }
            catch (Exception e)
            {
                return new ManufacturerResponse(false, e.Message);
            }

        }
        
        public async Task Delete(Manufacturer manufacturer)
        {
            await Collection.DeleteOneAsync(Builders<Manufacturer>.Filter.Where(m => m.Id == manufacturer.Id));
        }
    }
}