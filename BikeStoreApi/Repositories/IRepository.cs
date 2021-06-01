using System.Collections.Generic;
using System.Threading.Tasks;

namespace BikeStoreApi.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {


        public void Create(TEntity obj);
        public void Update(TEntity obj);
        public void Delete(string id);
        public Task<TEntity> GetById(string id);
        public Task<IEnumerable<TEntity>> GetAll();
    }
}