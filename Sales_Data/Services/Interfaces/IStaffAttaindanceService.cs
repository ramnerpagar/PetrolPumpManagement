using Sales_Data.Models;

namespace Sales_Data.Services.Interfaces
{
    public interface IStaffAttaindanceService
    {
        public SalesRecord GetStaffEntry(string tblStaffId, DateTime tblDate);

        public Boolean RemoveStaffEntry(string tblStaffId, DateTime tblDate);
    }
}
