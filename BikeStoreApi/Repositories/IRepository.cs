using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable
    {
        Task<TEntity> Get(string name);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}