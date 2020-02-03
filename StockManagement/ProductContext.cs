using Microsoft.EntityFrameworkCore;

namespace StockManagement
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Product.db");
            
        }
    }
}