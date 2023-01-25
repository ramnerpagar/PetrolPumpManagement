using Sales_Data.Models;

namespace Sales_Data.Services.Interfaces
{
    public interface IPumpSalesService
    {
        public Boolean CreatePumpRecordEntry(PumpRecord pumpRecord);
        public Boolean CreateSalesEntry(SalesRecord salesRecord);
    }
}
