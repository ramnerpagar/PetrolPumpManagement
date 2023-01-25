using Microsoft.EntityFrameworkCore;
using Staff_Data.Models;

namespace Staff_Data.DataContext
{
    public class StaffDBContext : DbContext
    {
        public StaffDBContext(DbContextOptions<StaffDBContext> options) : base(options) { }
        public DbSet<Staff> Staff_Data { get; set; }
        public DbSet<Retrench> Retrench_Data { get; set; }
        public DbSet<Suspend> Suspend_Data { get; set; }
        public DbSet<SeniorStaff> SeniorStaff_Data { get;set; }
        public DbSet<Retrench1> Retrench1_Data { get; set; }
        public DbSet<Suspend1> Suspend1_Data { get; set; }
        public DbSet<SecurityStaff> Security_Data { get; set; }
        public DbSet<Retrench2> Retrench2_Data { get; set; }
        public DbSet<Suspend2> Suspend2_Data { get; set; }

    }
    
}
