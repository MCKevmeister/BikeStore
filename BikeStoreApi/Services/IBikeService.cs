using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public interface IBikeService
    {
        ActionResult<List<Bike>> Get();
        Task<Bike> Get(ObjectId id);
        Bike Create(Bike bike);
        void Update(ObjectId id, Bike bikeIn);
        Task<DeleteResult> Remove(Bike bikeIn);
        Task<DeleteResult> Remove(ObjectId id);
    }
}