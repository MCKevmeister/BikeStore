using BikeStore.Models;
using BikeStoreApi.Services;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;

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

        public static void RegisterMongoDbClassMaps(this IServiceCollection servicesBuilder)
        {
            BsonClassMap.RegisterClassMap<Bike>(cm => {
                cm.AutoMap();
                cm.SetIsRootClass(true);
            });
            BsonClassMap.RegisterClassMap<ElectricBike>();
            BsonClassMap.RegisterClassMap<RoadBike>();
            BsonClassMap.RegisterClassMap<Order>();
            BsonClassMap.RegisterClassMap<Manufacturer>();
        }
    }
}