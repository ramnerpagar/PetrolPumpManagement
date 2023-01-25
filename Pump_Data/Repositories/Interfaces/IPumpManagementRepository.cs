using Microsoft.AspNetCore.Mvc;
using Pump_Data.Models;

namespace Pump_Data.Repositories.Interfaces
{
    public interface IPumpManagementRepository
    {
        public IEnumerable<PumpManagement> GetAllPumps();

        public Boolean CreatePump(PumpManagement Pump);

        public Boolean UpdatePump(short PumpId,PumpManagement NewPump);

        public Boolean DeletePump(short PumpId);
    }
}
