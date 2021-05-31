using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.IO;
using MongoDB.Driver.Core.Configuration;

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
            services.RegisterMongoDbRepositories();
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

            services.Configure<IBikeStoreDatabaseSettings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("BikeStoreDatabaseSettings:MongoUri").Value;
                options.DatabaseName = Configuration.GetSection("BikeStoreDatabaseSettings:DatabaseName").Value;
            });
                
                
            //services.Configure<BikeStoreDatabaseSettings>(configuration.GetSection("BikeStoreDatabaseSettings"));
            //services.AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<BikeStoreDatabaseSettings>());GetRequiredService<IConfiguration>()["MongoUri"]
            //services.AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IOptions<BikeStoreDatabaseSettings>>().Value);
            //services.AddSingleton<IBikeStoreDatabaseSettings>(x => x.GetRequiredService<IConfiguration>()["MongoUri"]);
            services.AddTransient<IMongoContext, MongoContext>();
            

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