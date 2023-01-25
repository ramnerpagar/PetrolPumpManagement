using Reports_Data.DBContext;
using Reports_Data.Repositories.Interfaces;

namespace Reports_Data.Repositories
{
    public class PumpDailyRepository : IPumpDailyReport
    {
        StaffSalaryDBContext staffSalaryDBContext;
        public PumpDailyRepository(StaffSalaryDBContext staffSalaryDBContext)
        {
            this.staffSalaryDBContext = staffSalaryDBContext;
        }

        public IEnumerable<Object> GetPumpDailyReport(string shift,DateTime date)
        {
            try
            {
                var data = staffSalaryDBContext.pump_data.Where(p => p.tblShift == shift && DateTime.Compare(p.tblDate.Date,date.Date) == 0).ToList();
                return data;
            }catch
            {
                return null;
            }

        }

    }
}
