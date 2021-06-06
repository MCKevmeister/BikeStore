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
        Task<Manufacturer> GetByName(string name);
        Task<IEnumerable<Manufacturer>> GetAll();
        Task<Manufacturer> Create(string manufacturerName, CancellationToken cancellationToken);
        Task<ManufacturerResponse> Update(UpdateManufacturer updateManufacturer, CancellationToken cancellationToken);
        Task Delete(Manufacturer manufacturer);
    }
}