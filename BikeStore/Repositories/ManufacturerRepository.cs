using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public class ManufacturerRepository : MongoContext, IManufacturerRepository
    {
        public ManufacturerRepository(IOptions<IBikeStoreDatabaseSettings> configuration) : base(configuration)
        {
        }

        public void Create(Manufacturer obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Manufacturer obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Manufacturer> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Manufacturer>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}