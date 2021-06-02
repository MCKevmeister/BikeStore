using BikeStoreApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace BikeStoreApi.Repositories
{
   public static class RepositoryExtensions
    {
        public static void RegisterMongoDbRepositories(this IServiceCollection servicesBuilder)
        {
            servicesBuilder.AddSingleton<IManufacturerRepository, ManufacturerRepository>();
            servicesBuilder.AddSingleton<IBikeRepository, BikeRepository>();
            servicesBuilder.AddSingleton<IOrderRepository, OrderRepository>();
        }

        public static void RegisterMongoDbServices(this IServiceCollection servicesBuilder)
        {
            servicesBuilder.AddSingleton<IBikeService, BikeService>();
            servicesBuilder.AddSingleton<IManufacturerService, ManufacturerService>();
            servicesBuilder.AddSingleton<IOrderService, OrderService>();
        }
    }
}