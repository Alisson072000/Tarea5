using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Tarea2
{
    class ApplicacionContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Panaderia> Panaderia { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("AppConfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoPanaderia>()
                .HasKey(pp => new { pp.ProductoId, pp.PanaderiaId });
            modelBuilder.Entity<ProductoPanaderia>()
            .HasOne(pp => pp.Producto)
            .WithMany(p => p.ProductoPanaderia)
            .HasForeignKey(pp => pp.ProductoId);
            modelBuilder.Entity<ProductoPanaderia>()
           .HasOne(pp => pp.Panaderia)
           .WithMany(p => p.ProductoPanaderia)
           .HasForeignKey(pp => pp.PanaderiaId);
        }
    }
}


