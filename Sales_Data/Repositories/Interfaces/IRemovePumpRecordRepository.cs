using Sales_Data.Models;

namespace Sales_Data.Repositories.Interfaces
{
    public interface IRemovePumpRecordRepository
    {
        public JsonData GetPumpDetails(int PumpId, double tblFinalLitres);

        public Boolean DeletPumpDetails(JsonData jsonData);
    }
}
