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

        public async Task<Manufacturer> Create(Manufacturer obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(typeof(Manufacturer) + "  is null");
            }

            await Collection.InsertOneAsync(obj);
            return await Collection.Find(Builders<Manufacturer>.Filter.Eq("_id", obj.Id)).FirstOrDefaultAsync();
        }


        public async Task<Manufacturer> GetByName(string name)
        {
            var filter = Builders<Manufacturer>.Filter.Eq("name", name);
            return await Collection.FindAsync<Manufacturer>(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            var all = await Collection.Find(Builders<Manufacturer>.Filter.Empty).ToListAsync();
            return all;
        }

        public async Task<ManufacturerResponse> Update(Manufacturer obj, Dictionary<string, string> details,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var filter = Builders<Manufacturer>.Filter.Eq("_id", obj.Id);
                var update = Builders<Manufacturer>.Update.Set(entity => entity.Details, details);
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
            await Collection.DeleteOneAsync(Builders<Manufacturer>.Filter.Eq("_id", manufacturer.Id));
        }
    }
}