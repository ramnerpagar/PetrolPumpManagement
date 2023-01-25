using Pump_Data.Models;
using Reports_Data.DBContext;
using Reports_Data.Repositories.Interfaces;
using Sales_Data.Models;

namespace Reports_Data.Repositories
{
    public class PumpAllSalesRepository : IPumpAllSalesRepository
    {
        StaffSalaryDBContext staffSalaryDBContext;
        public PumpAllSalesRepository(StaffSalaryDBContext staffSalaryDBContext) 
        {
            this.staffSalaryDBContext = staffSalaryDBContext;
        }

        public IEnumerable<PumpRecord> GetPumpSalesById(int id)
        {
            try
            {
                var data = staffSalaryDBContext.pump_data.Where(p => p.tblPumpID == id).ToList();
                Console.WriteLine(data);
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
