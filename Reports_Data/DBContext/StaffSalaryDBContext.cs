using Microsoft.EntityFrameworkCore;
using Reports_Data.Models;
using Staff_Data.Models;
using Sales_Data.Models;

namespace Reports_Data.DBContext
{
    public class StaffSalaryDBContext : DbContext
    {
        public StaffSalaryDBContext(DbContextOptions<StaffSalaryDBContext> options) : base(options) { }

        public DbSet<Dump_Data> Dump_Data { get; set; }

        public DbSet<PumpRecord> pump_data { get; set; }

        public DbSet<SalesRecord> Sales_Data { get; set; }

        public DbSet<Staff> Staff_Data { get; set; }
    }
}
