using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(IMongoContext context) : base(context)
        {
        }
    }
}