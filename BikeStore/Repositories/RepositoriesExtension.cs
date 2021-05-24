using BikeStore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace BikeStore.Server.Repositories
{
    public static class RepositoryExtensions
    {
        public static void RegisterMongoDbRepositories(this IServiceCollection servicesBuilder)
        {
            servicesBuilder.AddSingleton<ManufacturerRepository>();
            //servicesBuilder.AddSingleton<BikeRepository>();
            //servicesBuilder.AddSingleton<OrderRepository>();
        }
    }
}