using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
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

        public ActionResult<List<Manufacturer>> Get() =>
            _manufacturers.Find(manufacturer => true).ToList();

        public Task<Manufacturer> Get(string id) =>
            _manufacturers.Find(manufacturer => manufacturer.Id == id).FirstOrDefaultAsync();

        public Manufacturer Create(Manufacturer manufacturer)
        {
            _manufacturers.InsertOneAsync(manufacturer);
            return manufacturer;
        }

        public Task<ReplaceOneResult> Update(string id, Manufacturer manufacturerIn) =>
            _manufacturers.ReplaceOneAsync(manufacturer => manufacturer.Id == id, manufacturerIn);

        public Task<DeleteResult> Remove(Manufacturer manufacturerIn) =>
            _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == manufacturerIn.Id);

        public Task<DeleteResult> Remove(string id) =>
            _manufacturers.DeleteOneAsync(manufacturer => manufacturer.Id == id);
    }
}




// {
//     private readonly IMongoCollection<Manufacturer> _manufacturers;
//
//     public ManufacturerService(IMongoContext context)
//     {
//         Context = context;
//         _manufacturers = Context.Database.GetCollection<Manufacturer>(nameof(Manufacturer));
//     }
//
//     private IMongoContext Context { get; }
//
//     public IEnumerable<Manufacturer> GetAll()
//     {
//         return _manufacturers.Find(manufacturer => true).ToList();
//     }
//
//     public Manufacturer Get(string id)
//     {
//         return _manufacturers.Find(manufacturer => manufacturer.Id == id).FirstOrDefault();
//     }
//
//     public Manufacturer Create(Manufacturer manufacturer)
//     {
//         _manufacturers.InsertOne(manufacturer);
//         return manufacturer;
//     }
//
//     public void Update(string id, Manufacturer manufacturerIn)
//     {
//         _manufacturers.ReplaceOne(manufacturer => manufacturer.Id == id, manufacturerIn);
//     }
//
//     public void Remove(Manufacturer manufacturerIn)
//     {
//         _manufacturers.DeleteOne(manufacturer => manufacturer.Id == manufacturerIn.Id);
//     }
//
//     public void Remove(string id)
//     {
//         _manufacturers.DeleteOne(manufacturer => manufacturer.Id == id);
//     }
// }