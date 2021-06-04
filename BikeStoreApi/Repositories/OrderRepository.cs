using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;

namespace BikeStoreApi.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(IMongoContext context) : base(context)
        {
        }

        public Task<Order> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> Create(string manufacturerName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Order manufacturer)
        {
            throw new System.NotImplementedException();
        }
    }
}