using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task Create(TEntity obj);
        Task Update(TEntity obj);
        Task Delete(string id);
        Task<TEntity> GetById(string id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
//https://bryanavery.co.uk/asp-net-core-mongodb-repository-pattern-unit-of-work/ 2 June 21