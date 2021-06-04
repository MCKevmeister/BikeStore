using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public interface IBikeService
    {
        Task<ActionResult<List<Bike>>> Get();
        Task<Bike> Get(string id);
        Task<Bike> Create(Bike bike);
        Task<ReplaceOneResult> Update (string id, Bike bikeIn);
        Task<DeleteResult> Remove(Bike bikeIn);
        Task<DeleteResult> Remove(string id);
    }
}