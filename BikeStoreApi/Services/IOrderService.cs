using System.Collections.Generic;
using BikeStore.Models;
using MongoDB.Bson;

namespace BikeStoreApi.Services
{
    public interface IOrderService
    {
        List<Order> Get();
        Order Get(string id);
        Order Create(Order order);
        void Update(string id, Order orderIn);
        void Remove(Order orderIn);
        void Remove(string id);
    }
}