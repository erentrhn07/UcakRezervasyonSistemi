using Microsoft.EntityFrameworkCore;
using UcakRezervasyonSistemi.Models;

namespace UcakRezervasyonSistemi
{
    public class UcakRezervasyonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UcakRezervasyonContext.db");
        }

        public DbSet<Ucak> Ucak { get; set; }
        public DbSet<Lokasyon> Lokasyon { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
    }
}
