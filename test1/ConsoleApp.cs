using System;
using BikeStore.Server.Repositories;
using BikeStore.Server.Services;

namespace test1
{
    public class ConsoleApp : IConsoleApplication
    {
        private static IManufacturerService _manufacturerService;

        public ConsoleApp(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        public static void Run()
        {
            var manufacturers = _manufacturerService.GetAll();
            foreach (var manufacturer in manufacturers)
            {
                Console.WriteLine(manufacturer.Name);
            }

            Console.ReadKey();
        }
    }
}