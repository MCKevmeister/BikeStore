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
        private bool _disposed;

        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }
        
        public IManufacturerRepository ManufacturerRepository => _manufacturerRepository ??= new ManufacturerRepository(_context);
        public IOrderRepository OrderRepository => _orderRepository ??= new OrderRepository(_context);
        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();
            return changeAmount > 0;
        }

        public Task<IClientSessionHandle> StartSessionAsync(ClientSessionOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }
        

        public Task CommitTransactionAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }
        
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) { _context.Dispose(); }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}