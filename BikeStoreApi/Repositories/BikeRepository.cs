using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class BikeRepository : BaseRepository<Bike>, IBikeRepository
    {
        public BikeRepository(IMongoContext context) : base(context)
        {
        }
    }
}