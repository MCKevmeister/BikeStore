using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IManufacturerRepository : IRepository
    {
        Task<Manufacturer> Get(string name);
        Task<IEnumerable<Manufacturer>> GetAll();
        Task<Manufacturer> Create(Manufacturer manufacturer);
        Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer);
        Task Delete(Manufacturer manufacturer);
    }
}