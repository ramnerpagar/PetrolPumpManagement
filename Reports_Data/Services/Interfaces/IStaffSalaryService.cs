using Reports_Data.Models;

namespace Reports_Data.Services.Interfaces
{
    public interface IStaffSalaryService
    {
        public IEnumerable<Object> CalculateSalary(DateTime date1, DateTime date2);
    }
}
