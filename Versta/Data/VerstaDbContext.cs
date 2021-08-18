using Microsoft.EntityFrameworkCore;
using Versta.Models;

namespace Versta.Data
{
    public class VerstaDbContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        public VerstaDbContext(DbContextOptions<VerstaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(SampleData.Data);
        }
    }
}
