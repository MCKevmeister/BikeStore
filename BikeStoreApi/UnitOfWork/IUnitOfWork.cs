using System;
using System.Threading.Tasks;

namespace BikeStoreApi.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IManufacturerRepository ManufacturerRepository { get; }
        //IOrderRepository OrderRepository { get; }
        //IBikeRepository BikeRepository { get; }
        Task<bool> Commit();
    }
}