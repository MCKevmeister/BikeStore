﻿using System;
using System.Threading;
using System.Threading.Tasks;
using BikeStoreApi.Repositories;
using MongoDB.Driver;

namespace BikeStoreApi
{
    public interface IUnitOfWork : IDisposable
    {
        IManufacturerRepository ManufacturerRepository { get; }
        IOrderRepository OrderRepository { get; } 
        //IBikeRepository BikeRepository { get; }
        Task<bool> Commit();
        Task<IClientSessionHandle> StartSessionAsync(ClientSessionOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken));
        Task CommitTransactionAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}