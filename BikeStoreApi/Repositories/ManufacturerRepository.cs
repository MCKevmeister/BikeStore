using BikeStore.Models;
using BikeStore.Server.Repositories;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        }
    }
}