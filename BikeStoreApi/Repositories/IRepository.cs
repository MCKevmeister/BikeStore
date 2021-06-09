using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        void Create(TEntity entity);
        //Task<TEntity> Get(string id);
        Task<TEntity> GetById(string id);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity entity, string idOld);
        void Delete(string id);
    }
}