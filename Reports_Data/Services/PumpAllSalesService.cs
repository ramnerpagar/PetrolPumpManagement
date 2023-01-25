using Sales_Data.Models;
using Reports_Data.Repositories;
using Reports_Data.DBContext;
using Reports_Data.Services.Interfaces;

namespace Reports_Data.Services
{
    public class PumpAllSalesService : IPumpAllSalesService
    {
        PumpAllSalesRepository pumpAllSalesRepository;

        public PumpAllSalesService(StaffSalaryDBContext staffSalaryDBContext)
        {
            pumpAllSalesRepository = new PumpAllSalesRepository(staffSalaryDBContext);
        }

        public IEnumerable<PumpRecord> GetPumpSalesById(int id)
        {
            return pumpAllSalesRepository.GetPumpSalesById(id);
        }
    }
}
