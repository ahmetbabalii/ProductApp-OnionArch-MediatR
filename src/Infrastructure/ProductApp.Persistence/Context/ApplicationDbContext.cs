using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        // serviceregistration içerisinde ki dbcontextoption'ı base'e set ediyoruz
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product(){Id = Guid.NewGuid(),Name = "Pen",Value = 10,Quantity = 1000},
                new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Value = 1, Quantity = 2000 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 10, Quantity = 3000 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
