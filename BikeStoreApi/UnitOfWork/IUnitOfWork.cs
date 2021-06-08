using BikeStoreApi.Repositories;

namespace BikeStoreApi.UnitOfWork
{
    public interface IUnitOfWork 
    {
        void BeginTransaction();
        void SaveChanges();
        bool Commit();
        void Rollback();
        IRepository<TEntity> Repository<TEntity>();
    }
}