using Pump_Data.Models;
using Sales_Data.Models;

namespace Reports_Data.Repositories.Interfaces
{
    public interface IPumpAllSalesRepository
    {
        public IEnumerable<PumpRecord> GetPumpSalesById(int id);
    }
}
