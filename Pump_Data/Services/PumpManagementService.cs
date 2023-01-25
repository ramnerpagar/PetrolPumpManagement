using Pump_Data.DataContext;
using Pump_Data.Models;
using Pump_Data.Repositories;
using Pump_Data.Services.Interfaces;

namespace Pump_Data.Services
{
    public class PumpManagementService : IPumpManagementService
    {
        PumpManagementRepository pumpManagementRepository;
        public PumpManagementService(PumpDBContext pumpDBContext) 
        {
            pumpManagementRepository = new PumpManagementRepository(pumpDBContext);
        }

        public IEnumerable<PumpManagement> GetAllPumps()
        {
            return pumpManagementRepository.GetAllPumps();
        }

        public Boolean CreatePump(PumpManagement Pump)
        {
            return pumpManagementRepository.CreatePump(Pump);
        }

        public Boolean UpdatePump(short PumpId, PumpManagement NewPump)
        {
            return pumpManagementRepository.UpdatePump(PumpId, NewPump);
        }

        public Boolean DeletePump(short PumpId)
        {
            return pumpManagementRepository.DeletePump(PumpId);
        }

    }
}
