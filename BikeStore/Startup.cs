using System.IO;
using BikeStore.Models;
using BikeStore.Server.Repositories;
using BikeStore.Server.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace BikeStore.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();
            
            services.Configure<BikeStoreDatabaseSettings>(configuration.GetSection("BikeStoreDatabaseSettings"));
            services.AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoContext, MongoContext>();
            services.RegisterMongoDbRepositories();
            services.AddSingleton<IManufacturerService, ManufacturerService>();
            //services.AddSingleton<BikeService>();

            services.AddControllers();
        }
        
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
