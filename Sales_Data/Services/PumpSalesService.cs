using Sales_Data.DataContext;
using Sales_Data.Models;
using Sales_Data.Repositories;
using Sales_Data.Services.Interfaces;

namespace Sales_Data.Services
{
    public class PumpSalesService : IPumpSalesService
    {
        PumpSalesRepository pumpSalesRepository;
        public PumpSalesService(SalesDBContext salesDBContext) 
        {
            pumpSalesRepository = new PumpSalesRepository(salesDBContext);
        }

        public Boolean CreatePumpRecordEntry(PumpRecord pumpRecord)
        {
            return pumpSalesRepository.CreatePumpRecordEntry(pumpRecord);
        }
        public Boolean CreateSalesEntry(SalesRecord salesRecord)
        {
            return pumpSalesRepository.CreateSalesEntry(salesRecord);
        }
    }
}
