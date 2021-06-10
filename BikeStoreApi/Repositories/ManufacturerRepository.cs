using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IMongoContext context) : base(context)
        {
        } 
    }

}