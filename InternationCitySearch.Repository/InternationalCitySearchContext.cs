using InternationalCitySearch.Models;
using Microsoft.EntityFrameworkCore;

namespace InternationCitySearch.Repository
{
    public class InternationalCitySearchContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "InternationalCitySearchDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Name indexed for faster search
            modelBuilder.Entity<City>()
                .HasIndex(b => b.Name)
                .IsUnique();
        }

        public DbSet<City> Cities { get; set; }
    }
}
