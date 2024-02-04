using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Enttities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarWorkshopEntity> CarWorkshops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebApplication1;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
