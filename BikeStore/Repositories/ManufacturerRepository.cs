using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        }
    }
}