using BikeStore.Models;
using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public classAppDbContext: DbContext
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