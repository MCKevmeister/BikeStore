using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class RoadBikeRepository : BaseRepository<RoadBike>, IRoadBikeRepository
    {
        public RoadBikeRepository(IMongoContext context) : base(context)
        {
        }
    }
}