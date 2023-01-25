using Pump_Data.Models;

namespace Pump_Data.Services.Interfaces
{
    public interface IPumpManagementService
    {
        public IEnumerable<PumpManagement> GetAllPumps();

        public Boolean CreatePump(PumpManagement Pump);

        public Boolean UpdatePump(short PumpId,PumpManagement NewPump);

        public Boolean DeletePump(short PumpId);
    }
}
