using EpicShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EpicShopAPI.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my-db;Trusted_Connection=True;");
        }
    }
}
