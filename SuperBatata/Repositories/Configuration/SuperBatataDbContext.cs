using Microsoft.EntityFrameworkCore;
using SuperBatata.Api.Entities;

namespace SuperBatata.Api.Repositories.Configuration
{
    public class SuperBatataDbContext : DbContext
    {
        public DbSet<Batata> Batata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SuperBatata;Trusted_Connection=True;");
        }
    }
}
