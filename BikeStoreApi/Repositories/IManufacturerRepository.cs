using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
    public interface IManufacturerRepository : IRepository<Manufacturer>
    {
    }
}