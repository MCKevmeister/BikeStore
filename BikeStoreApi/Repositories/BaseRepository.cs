using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace BikeStoreApi.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IMongoContext _context;
        private readonly IMongoCollection<TEntity> _collection;

        protected BaseRepository(IMongoContext context)
        {
            _context = context;
            _collection = _context.GetCollection<TEntity>(typeof(TEntity).Name);
        }
        
        public void Add(TEntity obj)
        {
            _context.AddCommand(() => _collection.InsertOneAsync(obj));
        }
        public virtual async Task<TEntity> GetById(string id)
        {
            return await _collection.FindAsync(Builders<TEntity>.Filter.Eq("_id", ObjectId.Parse(id))).Result.FirstOrDefaultAsync();
        }
        public virtual void Create(TEntity entity)
        {
            _collection.InsertOneAsync(entity);
        }
        public virtual async Task<IList<TEntity>> GetAll()
        {
            return await _collection.FindAsync(Builders<TEntity>.Filter.Empty).Result.ToListAsync();
        }
        public virtual void Update(TEntity entity, string id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", ObjectId.Parse(id));
            _context.AddCommand(() => _collection.ReplaceOneAsync(filter, entity));
        }
        public virtual void Delete(string id)
        {
            _context.AddCommand(() => _collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", ObjectId.Parse(id))));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}