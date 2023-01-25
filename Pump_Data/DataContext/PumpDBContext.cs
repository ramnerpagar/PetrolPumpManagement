using Microsoft.EntityFrameworkCore;
using Pump_Data.Models;

namespace Pump_Data.DataContext
{
    public class PumpDBContext : DbContext
    {
        public PumpDBContext(DbContextOptions<PumpDBContext> options) : base(options) { }

        public DbSet<PumpManagement> Pump_Data { get; set; }
    }
}
