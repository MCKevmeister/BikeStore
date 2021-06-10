using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class ElectricBikeRepository : BaseRepository<ElectricBike>, IElectricBikeRepository
    {
        public ElectricBikeRepository(IMongoContext context) : base(context)
        {
        }
    }
}