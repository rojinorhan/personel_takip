using Microsoft.EntityFrameworkCore;
using PersonelTakipOtomasyonuApı.Models;

namespace PersonelTakipOtomasyonuApı.Efcore

{
    public class PersonelOtomasyonuEklemeDbContext : DbContext
    {
        
        
        public DbSet<Personel> personels { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conStr = "Server =DESKTOP-7915U5S\\ROJINA ; DataBase = PersonelTakipOtomasyonu ; User Id = PersonelYonetici ; Password =123456;TrustServerCertificate = true";
            optionsBuilder.UseSqlServer(conStr);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
