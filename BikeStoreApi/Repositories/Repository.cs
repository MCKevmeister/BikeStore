using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
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

        public async Task<TEntity> Create(TEntity obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await Collection.InsertOneAsync(obj);
            return await Collection.Find(Builders<TEntity>.Filter.Eq("_id", obj.Id)).FirstOrDefaultAsync();
            
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

        public async Task<TEntity> Update(TEntity obj, TEntity newDetails)
        {  
            var updatedEntity = await Collection.FindOneAndReplaceAsync(Builders<TEntity>.Filter.Eq("_id", obj.Id), newDetails);
            return updatedEntity;
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