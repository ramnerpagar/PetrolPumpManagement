using Microsoft.EntityFrameworkCore;
using Product_Data.Models;

namespace Product_Data.DataContext
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)  { }
        public DbSet<Product> Products_Data { get; set; }
    }
}
