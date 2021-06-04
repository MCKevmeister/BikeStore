using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task<TEntity> GetByName(string name);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Create(string entityName, CancellationToken cancellationToken);
        Task Delete(TEntity entity);
    }
}