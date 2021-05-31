using System.Collections.Generic;
using BikeStore.Models;

namespace BikeStoreApi.Services
{
    public interface IManufacturerService
    {
        List<Manufacturer> GetAll();
        Manufacturer Get(string id);
        Manufacturer Create(Manufacturer manufacturer);
        void Update(string id, Manufacturer manufacturerIn);
        void Remove(Manufacturer manufacturerIn);
        void Remove(string id);
    }
}