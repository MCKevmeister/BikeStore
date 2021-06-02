using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IManufacturerRepository : IRepository<Manufacturer>
    {
        Task<Manufacturer> GetByName(string name);
        Task<IEnumerable<Manufacturer>> GetAll();
        Task<Manufacturer> Create(Manufacturer newManufacturer);
        Task<ManufacturerResponse> Update(Manufacturer obj, Dictionary<string, string> details,
            CancellationToken cancellationToken = default);
        Task Delete(Manufacturer manufacturer);
    }
}