using Reports_Data.DBContext;
using Reports_Data.Models;
using Reports_Data.Repositories;
using Reports_Data.Services.Interfaces;

namespace Reports_Data.Services
{
    public class StaffSalaryService : IStaffSalaryService
    {
        StaffSalaryRepositoy staffSalaryRepositoy;
        public StaffSalaryService(StaffSalaryDBContext staffSalaryDBContext)
        {
            staffSalaryRepositoy = new StaffSalaryRepositoy(staffSalaryDBContext);

        }

        public IEnumerable<Object> CalculateSalary(DateTime date1, DateTime date2)
        {
            return staffSalaryRepositoy.CalculateSalary(date1, date2);
        }
    }
}
