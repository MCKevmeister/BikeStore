/*using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public class BikeService : IBikeService
    {
        //private readonly IMongoCollection<Bike> _bikes;
        private readonly IBikeService _bikeService;
        private static IBikeRepository _bikeRepository;

        public BikeService(IBikeRepository bikeRepository, IBikeService bikeService)
        {
            _bikeService = bikeService;
            _bikeRepository = bikeRepository;
        }

        public async Task<ActionResult<List<Bike>>> Get() =>
            await _bikeRepository.Find(bike => true).ToListAsync();

        public async Task<Bike> Get(string id) =>
            await _bikes.Find(bike => bike.Id == id).FirstOrDefaultAsync();

        public async Task<Bike> Create(Bike bike)
        {
            await _bikes.InsertOneAsync(bike);
            return bike;
        }
        
        public async Task<ReplaceOneResult> Update(string id, Bike bikeIn) =>
            await _bikes.ReplaceOneAsync(bike => bike.Id == id, bikeIn);

        public async Task<DeleteResult> Remove(Bike bikeIn) =>
            await _bikes.DeleteOneAsync(bike => bike.Id == bikeIn.Id);

        public async Task<DeleteResult> Remove(string id) => 
            await _bikes.DeleteOneAsync(bike => bike.Id == id);
    }
}*/