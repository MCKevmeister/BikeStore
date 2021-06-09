using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        } 
    }

}
/* public class ManufacturerRepository : IManufacturerRepository
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
     public async Task<Manufacturer> Update(Manufacturer manufacturer)
     {
         var filter = Builders<Manufacturer>.Filter.Eq("_id", manufacturer.Id);
         var update = Builders<Manufacturer>.Update.Set(m => m.Name, manufacturer.Name);
         var updateOptions =  new UpdateOptions { IsUpsert = false};
         var result = await _collection.UpdateOneAsync(filter, update, updateOptions);
         return result.IsAcknowledged ? manufacturer : null;
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
}*/