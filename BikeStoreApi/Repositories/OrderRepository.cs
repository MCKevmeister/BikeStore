using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(IMongoContext context) : base(context)
        {
        }
    }
}