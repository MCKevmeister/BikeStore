using System;

using BikeStore.Models;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        protected IMongoCollection<TEntity> Collection { get; }

        protected Repository(IMongoContext context)
        {
            Collection = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public void Dispose ()
        {
            GC.SuppressFinalize(this);
        }
    }   
}