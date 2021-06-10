using BikeStore.Models;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Serializers;

namespace BikeStoreApi.Repositories
{
   public static class RepositoryExtensions
    {
        public static void Configure()
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.CSharpLegacy));

            var pack = new ConventionPack
            {
                new CamelCaseElementNameConvention(),
                new IgnoreExtraElementsConvention(true),
                new IgnoreIfDefaultConvention(true)
            };
            ConventionRegistry.Register("My Solution Conventions", pack, t => true);
        }
        public static void RegisterMongoDbRepositories(this IServiceCollection servicesBuilder)
        {
            servicesBuilder.AddSingleton<IManufacturerRepository, ManufacturerRepository>();
            servicesBuilder.AddSingleton<IRoadBikeRepository, RoadBikeRepository>();
            servicesBuilder.AddSingleton<IElectricBikeRepository, ElectricBikeRepository>();
            servicesBuilder.AddSingleton<IOrderRepository, OrderRepository>();
        }

        public static void RegisterMongoDbClassMaps(this IServiceCollection servicesBuilder)
        {
            BsonClassMap.RegisterClassMap<Bike>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(bike => bike.Id);
                map.MapIdMember(x => x.Id);
                map.MapMember(eBike => eBike.Name);
                map.MapMember(eBike => eBike.ManufacturerId);
                map.MapMember(eBike => eBike.Price);
                map.MapMember(eBike => eBike.Description);
                map.MapMember(eBike => eBike.Weight);
                map.MapMember(eBike => eBike.LastModified);
                map.MapMember(eBike => eBike.StockAmount);
            });
            BsonClassMap.RegisterClassMap<ElectricBike>(map => {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapMember(bike => bike.Motor);
            });
            BsonClassMap.RegisterClassMap<RoadBike>(map => {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapMember(bike => bike.BrakeType);
            });
            BsonClassMap.RegisterClassMap<Order>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(order => order.Id);
                map.MapMember(order => order.BikeId);
                map.MapMember(order => order.CustomerName);
                map.MapMember(order => order.CustomerEmail);
                map.MapMember(order => order.TotalAmount);
                map.MapMember(order => order.OrderDate);
            });
            BsonClassMap.RegisterClassMap<Manufacturer>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(manufacturer => manufacturer.Id);
                map.MapMember(manufacturer => manufacturer.Name).SetIsRequired(true);
            });
        }
    }
}