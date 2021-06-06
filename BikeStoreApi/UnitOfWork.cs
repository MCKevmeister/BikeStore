using System;
using System.Threading;
using System.Threading.Tasks;
using BikeStoreApi.Repositories;
using MongoDB.Driver;

namespace BikeStoreApi
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;
        private IManufacturerRepository _manufacturerRepository;
        private IOrderRepository _orderRepository;
        //IBikeRepository BikeRepository { get; }

        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }
        
        public IManufacturerRepository ManufacturerRepository => _manufacturerRepository ??= new ManufacturerRepository(_context);
        public IOrderRepository OrderRepository => _orderRepository ??= new OrderRepository(_context);
        public async Task<bool> Commit()
        {
            var changeAmount = await _context.CommitChanges();
            return changeAmount > 0;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}