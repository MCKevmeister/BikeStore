using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public interface IManufacturerService
    {
        ActionResult<List<Manufacturer>> GetAll();
        Task<Manufacturer> Get(ObjectId id);
        Manufacturer Create(Manufacturer manufacturer);
        Task<ReplaceOneResult> Update(ObjectId id, Manufacturer manufacturerIn);
        Task<DeleteResult> Remove(Manufacturer manufacturerIn);
        Task<DeleteResult> Remove(ObjectId id);
    }
}