using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;
using BikeStore.Models;
using BikeStore.Server.Repositories;

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
                .Configure<BikeStoreDatabaseSettings>(configuration.GetSection("BikeStoreDatabaseSettings"))
                .AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value)
                .AddSingleton<MongoContext, MongoContext>()
                .AddSingleton<IConsoleApplication, ConsoleApp>()
                //.RegisterRepositories()
                //.RegisterServices()
                .BuildServiceProvider();
            ConsoleApp.Run();
        }
    }
}