/*using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class BikeRepository : IRepository<Bike>, IBikeRepository
    {
        private IMongoCollection<Bike> Collection { get; }
        private readonly IMongoContext _context;

        protected BikeRepository(IMongoContext context, IMongoContext mongoContext)
        {
            _context = mongoContext;
            Collection = context.GetCollection<Bike>(nameof(Bike));
        }
        
        public async Task<Bike> GetByName(string name)
        {
            var filter = Builders<Bike>.Filter.Eq("name", name);
            return await Collection.FindAsync<Bike>(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Bike>> GetAll()
        {
            var bikes = await Collection.Find(Builders<Bike>.Filter.Empty).ToListAsync();
            return bikes;
        }

        public Task<Bike> Create(string entityName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Bike entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UpdateBike updateBike, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}*/