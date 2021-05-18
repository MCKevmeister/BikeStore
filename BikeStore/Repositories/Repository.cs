using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IMongoContext _context;
        private readonly IMongoCollection<TEntity> _collection;
        protected Repository(IMongoContext context)
        {
            _context = context; 
            _collection = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual void Create(TEntity obj)
        {
            _context.AddCommand( () => _collection.InsertOneAsync(obj));
        }
        
        public  async Task<TEntity> GetById(string id)
        {
            var data = await _collection.FindAsync(Builders<TEntity>.Filter.Eq("_id", id));
            return await data.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await _collection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public virtual void Update(TEntity obj)
        {
            _context.AddCommand(() => _collection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.GetId()), obj)); //ToDo
        }
        
        public void Delete(string id)
        {
            _context.AddCommand(() => _collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id)));
        }
    }   
}