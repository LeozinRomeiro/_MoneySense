using Microsoft.EntityFrameworkCore;

namespace MoneySense.Data
{
    public class DataContext : DbContext
    {
        //public DbSet<FillingStation> FillingStations { get; set; }
        //public DbSet<Fuel> Fuels { get; set; }
        //public DbSet<Price> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Data;User ID=sa;Password=Leoadmin32@#$;Trusted_Connection=False;TrustServerCertificate=True;");
            //optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PriceMap());
            //modelBuilder.ApplyConfiguration(new FillingStationMap());
            //modelBuilder.ApplyConfiguration(new FuelMap());
        }
    }
}
