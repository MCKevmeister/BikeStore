using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BikeStoreApi.Services
{
    public interface IManufacturerService
    {
        Task<IEnumerable<Manufacturer>> GetAll();
        Task<Manufacturer> Get(Manufacturer manufacturer);
        Task<Manufacturer> Create(Manufacturer manufacturer);
        Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer);
        Task Remove(Manufacturer manufacturer);
    }
}