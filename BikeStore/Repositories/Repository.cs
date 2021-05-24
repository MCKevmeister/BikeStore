using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        private readonly IMongoContext _context;
        protected IMongoCollection<TEntity> Collection { get; }

        protected Repository(IMongoContext context)
        {
            _context = context; 
            Collection = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual void Create(TEntity obj)
        {
             Collection.InsertOneAsync(obj);
        }
        
        public  async Task<TEntity> GetById(string id)
        {
            var data = await Collection.FindAsync(Builders<TEntity>.Filter.Eq("_id", id));
            return await data.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await Collection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public virtual void Update(TEntity obj)
        {
            Collection.ReplaceOneAsync(e=> e.Id == obj.Id, obj);
        }
        
        public void Delete(string id)
        {
            Collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
        }
    }   
}