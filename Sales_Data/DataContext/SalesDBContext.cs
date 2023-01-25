using Microsoft.EntityFrameworkCore;
using Sales_Data.Models;
using Pump_Data.Models;

namespace Sales_Data.DataContext
{
    public class SalesDBContext : DbContext
    {
        public SalesDBContext(DbContextOptions<SalesDBContext> options) : base(options) { }

        public DbSet<SalesRecord> Sales_Data { get; set; }

        public DbSet<PumpRecord> Pump_Data { get; set;}

        public DbSet<PumpManagement> Pump_Manage_Data { get; set; }
    }
}
