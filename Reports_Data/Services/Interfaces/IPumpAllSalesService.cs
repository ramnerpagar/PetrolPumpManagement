using Sales_Data.Models;

namespace Reports_Data.Services.Interfaces
{
    public interface IPumpAllSalesService
    {
        public IEnumerable<PumpRecord> GetPumpSalesById(int id);
    }
}
