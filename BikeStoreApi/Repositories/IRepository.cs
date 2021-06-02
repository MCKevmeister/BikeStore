using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task Create(TEntity obj);
        Task Update(TEntity obj);
        Task Delete(string id);
        Task<TEntity> GetByName(string name);
        Task<IEnumerable<TEntity>> GetAll();
    }
}