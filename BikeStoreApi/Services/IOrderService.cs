using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Bson;

namespace BikeStoreApi.Services
{
    public interface IOrderService
    {
        List<Order> Get();
        Order Get(ObjectId id);
        Order Create(Order order);
        void Update(ObjectId id, Order orderIn);
        void Remove(Order orderIn);
        void Remove(ObjectId id);
    }
}