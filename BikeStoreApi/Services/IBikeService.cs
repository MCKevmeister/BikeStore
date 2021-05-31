using System.Collections.Generic;
using BikeStore.Models;

namespace BikeStoreApi.Services
{
    public interface IBikeService
    {
        List<Bike> Get();
        Bike Get(string id);
        Bike Create(Bike bike);
        void Update(string id, Bike bikeIn);
        void Remove(Bike bikeIn);
        void Remove(string id);
    }
}