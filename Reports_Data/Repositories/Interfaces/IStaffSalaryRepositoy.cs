using Reports_Data.Models;

namespace Reports_Data.Repositories.Interfaces
{
    public interface IStaffSalaryRepositoy
    {
        public IEnumerable<Object> CalculateSalary(DateTime date1, DateTime date2);
    }
}
