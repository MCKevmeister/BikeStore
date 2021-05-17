using Microsoft.EntityFrameworkCore;

namespace BikeStoreServer.Models
{
    public class AppDbContext: DbContext
    {
        private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<Bike> Bikes { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        // }

    }
}