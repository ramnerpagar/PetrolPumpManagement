using Sales_Data.DataContext;
using Sales_Data.Models;
using Sales_Data.Repositories;
using Sales_Data.Services.Interfaces;

namespace Sales_Data.Services
{
    public class RemovePumpRecordService : IRemovePumpRecordService
    {
        RemovePumpRecordRepository removePumpRecordRepository;
        public RemovePumpRecordService(SalesDBContext salesDBContext) 
        {
            removePumpRecordRepository = new RemovePumpRecordRepository(salesDBContext);
        }

        public JsonData GetPumpDetails(int PumpId, double tblFinalLitres)
        {
            return removePumpRecordRepository.GetPumpDetails(PumpId, tblFinalLitres);
        }

        public Boolean DeletPumpDetails(JsonData jsonData)
        {
            return removePumpRecordRepository.DeletPumpDetails(jsonData);
        }

    }
}
