using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IO;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using BikeStore.Server.Services;
using MongoDB.Driver;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {  
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }

        public void ConfigureServices(IServiceCollection services)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var build = builder.Build();
            
                services.Configure<BikeStoreDatabaseSettings>(build.GetSection("BikeStoreDatabaseSettings"));
                services.AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value);
                services.AddSingleton<IMongoContext, MongoContext>;
                services.RegisterMongoDbRepositories();
                services.AddSingleton<IManufacturerService, ManufacturerService>();

                services.AddControllers();
                services.BuildServiceProvider();
                ConsoleApp.Run();
            }
            //var configuration = builder.Build();
            
            //var serviceProvider = new ServiceCollection()
            
                // services.Configure<BikeStoreDatabaseSettings>(configuration.GetSection("BikeStoreDatabaseSettings"))
                // .AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value)
                // .AddSingleton<IMongoContext, MongoContext>()
                // .AddSingleton<IManufacturerRepository, ManufacturerRepository>()
                // .AddSingleton<ManufacturerService, ManufacturerService>()
                // .AddSingleton<IConsoleApplication, ConsoleApp>()
                    
                //.RegisterRepositories()
                //.RegisterServices()
    }
}