using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public interface IManufacturerService
    {
        ActionResult<List<Manufacturer>> Get();
        Task<Manufacturer> Get(string id);
        Manufacturer Create(Manufacturer manufacturer);
        Task<ReplaceOneResult> Update(string id, Manufacturer manufacturerIn);
        Task<DeleteResult> Remove(Manufacturer manufacturerIn);
        Task<DeleteResult> Remove(string id);
    }
}