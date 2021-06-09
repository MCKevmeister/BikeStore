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
            servicesBuilder.AddSingleton<IBikeRepository, BikeRepository>();
            servicesBuilder.AddSingleton<IOrderRepository, OrderRepository>();
        }

        public static void RegisterMongoDbClassMaps(this IServiceCollection servicesBuilder)
        {
            /*BsonClassMap.RegisterClassMap<Bike>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
            });
            BsonClassMap.RegisterClassMap<ElectricBike>(map => {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
            });
            BsonClassMap.RegisterClassMap<RoadBike>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
            });
            BsonClassMap.RegisterClassMap<Order>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
            });*/
            BsonClassMap.RegisterClassMap<Manufacturer>(map => {
                map.AutoMap();
                map.SetIsRootClass(true);
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(manufacturer => manufacturer.Id);
                map.IdMemberMap.SetRepresentation(BsonType.ObjectId);
                map.MapMember(manufacturer => manufacturer.Name).SetIsRequired(true);
            });
        }
    }
}