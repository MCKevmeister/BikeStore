using System;
using System.Threading.Tasks;

namespace BikeStoreApi.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}