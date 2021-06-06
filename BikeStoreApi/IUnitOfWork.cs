using System;
using System.Threading;
using System.Threading.Tasks;
using BikeStoreApi.Repositories;
using MongoDB.Driver;

namespace BikeStoreApi
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}