using Microsoft.AspNetCore.Mvc;
using Sales_Data.DataContext;
using Sales_Data.Models;

namespace Sales_Data.Repositories
{
    public class RemovePumpRecordRepository
    {
        SalesDBContext SalesDBContext;

        public RemovePumpRecordRepository(SalesDBContext salesDBContext) 
        { 
            this.SalesDBContext = salesDBContext;
        }

        public JsonData GetPumpDetails(int PumpId, double tblFinalLitres)
        {
            try
            {
                var pumpRecord = SalesDBContext.Pump_Data.Where(s => s.tblPumpID == PumpId && s.tblFinalLitres == tblFinalLitres).FirstOrDefault();
                if (pumpRecord == null)
                {
                    return new JsonData();
                }
                var pumpSales = SalesDBContext.Sales_Data.Where(s => s.tblShiftPump == pumpRecord.tblPumpID && s.tblShift == pumpRecord.tblShift && s.tblStaffID == pumpRecord.tblStaffId).FirstOrDefault();
                if (pumpSales == null)
                {
                    return new JsonData();
                }
                JsonData jsonData = new JsonData();
                jsonData.tblPumpID = PumpId;
                jsonData.tblDate1 = pumpRecord.tblDate;
                jsonData.tblInitialLitres = pumpRecord.tblInitialLitres;
                jsonData.tblFinalLitres= pumpRecord.tblFinalLitres;
                jsonData.tblDate2 = pumpSales.tblDate;
                jsonData.tblStaffID = pumpSales.tblStaffID;
                jsonData.tblShift = pumpSales.tblShift;

                return jsonData;
            }
            catch
            {
                return new JsonData();
            }
        }
        
        public Boolean DeletPumpDetails(JsonData jsonData)
        {
            try
            {
                var data = SalesDBContext.Pump_Manage_Data.Where(s => s.tblPumpID == jsonData.tblPumpID).FirstOrDefault();
                if (data == null)
                {
                    return false;
                }
                data.tblLastReading = jsonData.tblInitialLitres;
                var PumpData = SalesDBContext.Pump_Data.Where(s => s.tblPumpID == jsonData.tblPumpID && s.tblFinalLitres == jsonData.tblFinalLitres).FirstOrDefault();
                if (PumpData == null)
                {
                    return false;
                }
                var PumpSales = SalesDBContext.Sales_Data.Where(s => s.tblShiftPump == jsonData.tblPumpID && s.tblShift == jsonData.tblShift && s.tblStaffID == jsonData.tblStaffID && DateTime.Compare(s.tblDate.Date, jsonData.tblDate2.Date) == 0).FirstOrDefault();
                if (PumpSales == null)
                {
                    return false;
                }
                SalesDBContext.Sales_Data.Remove(PumpSales);
                SalesDBContext.Pump_Data.Remove(PumpData);
                SalesDBContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
