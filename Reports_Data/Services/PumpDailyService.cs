using Reports_Data.Services.Interfaces;
using Reports_Data.Repositories;
using Reports_Data.DBContext;

namespace Reports_Data.Services
{
    public class PumpDailyService : IPumpDailyService
    {
        PumpDailyRepository pumpDailyReport;

        public PumpDailyService(StaffSalaryDBContext staffSalaryDBContext) 
        {
            pumpDailyReport = new PumpDailyRepository(staffSalaryDBContext);
        }

        public IEnumerable<Object> GetPumpDailyReport(string shift, DateTime date)
        {
            try
            {
                return pumpDailyReport.GetPumpDailyReport(shift, date);
            }
            catch
            {
                return null;
            }
        }
    }
}
