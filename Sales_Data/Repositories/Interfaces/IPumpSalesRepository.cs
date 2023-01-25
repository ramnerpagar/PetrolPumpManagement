using Sales_Data.Models;

namespace Sales_Data.Repositories.Interfaces
{
    public interface IPumpSalesRepository
    {
        public Boolean CreatePumpRecordEntry(PumpRecord pumpRecord);
        public Boolean CreateSalesEntry(SalesRecord salesRecord);
    }
}
