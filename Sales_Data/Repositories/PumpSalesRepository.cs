using Sales_Data.DataContext;
using Sales_Data.Models;
using Sales_Data.Repositories.Interfaces;

namespace Sales_Data.Repositories
{
    public class PumpSalesRepository : IPumpSalesRepository
    {
        SalesDBContext SalesDBContext;
        public PumpSalesRepository(SalesDBContext salesDBContext) 
        {
            this.SalesDBContext = salesDBContext;
        }

        public Boolean CreatePumpRecordEntry(PumpRecord pumpRecord)
        {
            try
            {
                SalesDBContext.Pump_Data.Add(pumpRecord);
                var PumpData = SalesDBContext.Pump_Manage_Data.Where(s => s.tblPumpID == pumpRecord.tblPumpID).FirstOrDefault();
                if (PumpData != null)
                {
                    PumpData.tblLastReading = pumpRecord.tblFinalLitres;
                }
                else
                {
                    return false;
                }
                SalesDBContext.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
        }

        public Boolean CreateSalesEntry(SalesRecord salesRecord)
        {
            try
            {
                SalesDBContext.Sales_Data.Add(salesRecord);
                SalesDBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
