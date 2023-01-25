using Admin_Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin_Data.DataContext
{
    public class AdminDBContext : DbContext
    {
        public AdminDBContext(DbContextOptions<AdminDBContext> options) : base(options) { }

        public DbSet<AdminLogin> Admin_Data { get; set; }
    }
}
