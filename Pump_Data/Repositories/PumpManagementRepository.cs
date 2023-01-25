using Pump_Data.DataContext;
using Pump_Data.Models;
using Pump_Data.Repositories.Interfaces;

namespace Pump_Data.Repositories
{
    public class PumpManagementRepository : IPumpManagementRepository
    {
        PumpDBContext pumpDBContext;
        public PumpManagementRepository(PumpDBContext pumpDBContext) 
        {
            this.pumpDBContext = pumpDBContext;
        }

        public IEnumerable<PumpManagement> GetAllPumps()
        {
            try
            {
                return pumpDBContext.Pump_Data.ToList();
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean CreatePump(PumpManagement Pump)
        {
            try
            {
                pumpDBContext.Pump_Data.Add(Pump);
                pumpDBContext.SaveChanges();
                return true;
            }
            catch 
            {
                //left for logging
                throw null;
            }
        }

        public Boolean UpdatePump(short PumpId, PumpManagement NewPump)
        {
            try
            {
                var Pump = pumpDBContext.Pump_Data.Find(PumpId);
                if(Pump!=null)
                {
                    Pump.tblResetValue = NewPump.tblResetValue;
                    Pump.tblLastReading = NewPump.tblLastReading;
                    Pump.tblPumpType = NewPump.tblPumpType;
                    pumpDBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }

        public Boolean DeletePump(short PumpId)
        {
            try
            {
                var Pump = pumpDBContext.Pump_Data.Find(PumpId);
                if(Pump!= null)
                {
                    pumpDBContext.Pump_Data.Remove(Pump);
                    pumpDBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }
    }
}
