using Sales_Data.Models;

namespace Sales_Data.Services.Interfaces
{
    public interface IRemovePumpRecordService
    {
        public JsonData GetPumpDetails(int PumpId, double tblFinalLitres);

        public Boolean DeletPumpDetails(JsonData jsonData);
    }
}
