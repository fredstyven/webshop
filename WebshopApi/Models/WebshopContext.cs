using Microsoft.EntityFrameworkCore;

namespace WebshopApi.Models
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options)
            : base(options)
        {
        }

        public DbSet<WebshopItem> WebshopItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebshopItem>().ToTable("WebshopItem");   
        }
    }
}