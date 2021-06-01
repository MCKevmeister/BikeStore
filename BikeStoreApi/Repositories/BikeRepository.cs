using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class BikeRepository : Repository<Bike>, IBikeRepository
    {
        public BikeRepository(IMongoContext context) : base(context)
        {
        }
    }
}