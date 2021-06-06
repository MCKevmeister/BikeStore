using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IRepository: IDisposable
    {
    }
}