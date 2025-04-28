using Microsoft.EntityFrameworkCore;
using T_Shirt_E_commerce.Models;

namespace T_Shirt_E_commerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
