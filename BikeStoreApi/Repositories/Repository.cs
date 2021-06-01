using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        private IMongoCollection<TEntity> Collection { get; }

        protected Repository(IMongoContext context)
        {
            Collection = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task Create(TEntity obj)
        {
            await Collection.InsertOneAsync(obj);
        }
        
        public async Task<TEntity> GetById(string id)
        {
            var data = await Collection.FindAsync(Builders<TEntity>.Filter.Eq("_id", id));
            return await data.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await Collection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public async Task Update(TEntity obj)
        {
            await Collection.ReplaceOneAsync(e=> e.Id == obj.Id, obj);
        }
        
        public async Task Delete(string id)
        {
            await Collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
        }

        public void Dispose ()
        {
            GC.SuppressFinalize(this);
        }
    }   
}