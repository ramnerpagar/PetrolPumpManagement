using Sales_Data.Models;

namespace Sales_Data.Repositories.Interfaces
{
    public interface IStaffAttaindanceRepository
    {
        public SalesRecord GetStaffEntry(string tblStaffId, DateTime tblDate);

        public Boolean RemoveStaffEntry(string tblStaffId, DateTime tblDate);
    }
}
