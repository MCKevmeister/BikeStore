using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        private IMongoCollection<TEntity> Collection { get; }

        protected Repository(IMongoContext context)
        {
            Collection = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task Create(TEntity obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await Collection.InsertOneAsync(obj);
        }
        
        public async Task<TEntity> GetByName(string name)
        {
            var filter = Builders<TEntity>.Filter.Eq("name", name);
            return await Collection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await Collection.FindAsync(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public async Task Update(TEntity obj)
        {
            await Collection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.Id), obj);
        }

        public async Task Delete(ObjectId id)
        {
            await Collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
        }

        public void Dispose ()
        {
            GC.SuppressFinalize(this);
        }
    }   
}