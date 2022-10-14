using Microsoft.EntityFrameworkCore;
using SuperBatata.Api.Entities;

using System.Security.Policy;

namespace SuperBatata.Api.Repositories.Configuration
{
    public class SuperBatataDbContext : DbContext
    {
        public DbSet<Potato> Potato { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SuperBatata;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Potato>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.UrlImage);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Client).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Additional).IsRequired();
                entity.HasMany(e => e.Products).WithOne();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.OrderId).IsRequired();
                entity.Property(e => e.PotatoId).IsRequired();
                entity.HasOne(e => e.Order)
                      .WithMany(e => e.Products)
                      .HasForeignKey(e => e.OrderId);
                entity.HasOne(e => e.Potato)
                      .WithMany(e => e.Products)
                      .HasForeignKey(e => e.PotatoId);
            });
        }
    }
}
