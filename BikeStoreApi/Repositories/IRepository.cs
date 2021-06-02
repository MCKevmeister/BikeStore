using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task<TEntity> Create(TEntity obj);
        Task<TEntity> Update(TEntity obj, TEntity newObj);
        Task Delete(string id);
        Task<TEntity> GetByName(string name);
        Task<IEnumerable<TEntity>> GetAll();
    }
}