using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        }
    }
}