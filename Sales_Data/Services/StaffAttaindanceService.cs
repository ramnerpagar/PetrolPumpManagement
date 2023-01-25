using Sales_Data.DataContext;
using Sales_Data.Models;
using Sales_Data.Repositories;
using Sales_Data.Services.Interfaces;

namespace Sales_Data.Services
{
    public class StaffAttaindanceService : IStaffAttaindanceService
    {
        public StaffAttaindanceRepository staffAttaindanceRepository;
        public StaffAttaindanceService(SalesDBContext salesDBContext)
        {
            staffAttaindanceRepository = new StaffAttaindanceRepository(salesDBContext);
        }
        public SalesRecord GetStaffEntry(string tblStaffId, DateTime tblDate)
        {
            return staffAttaindanceRepository.GetStaffEntry(tblStaffId, tblDate);
        }

        public Boolean RemoveStaffEntry(string tblStaffId, DateTime tblDate)
        {
            return staffAttaindanceRepository.RemoveStaffEntry(tblStaffId, tblDate);
        }
    }
}
