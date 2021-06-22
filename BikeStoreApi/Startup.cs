using System.IO;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace BikeStoreApi
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
            services.AddSingleton<IBikeStoreDatabaseSettings>(x =>
                x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoContext, MongoContext>();
            services.AddSingleton<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.RegisterMongoDbRepositories();
            services.RegisterMongoDbClassMaps();
            services.AddSwaggerDocument();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "BikeStoreApi", Version = "v1"});
            });
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();              
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BikeStoreApi v1"));
            }

            app.UseOpenApi();
               
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
