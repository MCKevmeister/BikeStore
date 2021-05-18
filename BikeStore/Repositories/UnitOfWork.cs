using System.Threading.Tasks;

namespace BikeStore.Server.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;

        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();

            return changeAmount > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

// using System;
// using BikeStore.Models;
// using Microsoft.Extensions.Options;
// using MongoDB.Driver;
//
// namespace BikeStore.Server.Repositories
// {
//     public sealed class UnitOfWork : IUnitOfWork, IDisposable
//     {
//         private readonly IOptions<IBikeStoreDatabaseSettings> _context;
//         private IManufacturerRepository _manufacturerRepository;
//         // private IOrderRepository _orderRepository;
//         // private IBikeRepository _bikeRepository;
//         
//         public UnitOfWork()
//         {
//             _context = new MongoContext();
//         }
//         public IManufacturerRepository ManufacturerRepository
//         {
//             get
//             {
//                 if (_manufacturerRepository == null)
//                 {
//                     _manufacturerRepository = new ManufacturerRepository(_context);
//                 }
//                 return _manufacturerRepository;
//             }
//         }
//         
//         public void BeginTransaction()
//         {
//             throw new NotImplementedException();
//         }
//
//         public void SaveChanges()
//         {
//             throw new NotImplementedException();
//         }
//
//         public bool Commit()
//         {
//             throw new NotImplementedException();
//         }
//
//         public void Rollback()
//         {
//             throw new NotImplementedException();
//         }
//
//         public void Dispose()
//         {
//         }
//     }
// }