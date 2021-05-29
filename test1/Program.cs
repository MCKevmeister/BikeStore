using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IO;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using BikeStore.Server.Services;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

            var serviceProvider = new ServiceCollection()
                .Configure<BikeStoreDatabaseSettings>(configuration.GetSection("DatabaseSettings"))
                .AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value)
                .AddScoped<IMongoContext, MongoContext>()
                .AddScoped<IManufacturerRepository, ManufacturerRepository>()
                .AddScoped<IManufacturerService, ManufacturerService>()
                .AddSingleton<IConsoleApp, ConsoleApp>()
                //.RegisterRepositories()
                //.RegisterServices()
                .BuildServiceProvider();

            serviceProvider.GetRequiredService<IConsoleApp>().Run();
        }
    }
}