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
            //servicesBuilder.AddSingleton<BikeRepository>();
            //servicesBuilder.AddSingleton<OrderRepository>();
        }
    }
}