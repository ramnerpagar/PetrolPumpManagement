using Microsoft.AspNetCore.Mvc;
using Staff_Data.Models;

namespace Staff_Data.Services.Interfaces
{
    public interface IStaffService
    {
        public IEnumerable<Staff> GetStaff();
        public Staff AddStaff(Staff staff);
        public Boolean UpdateStaff(Staff staff);
        public Boolean RetrenchStaff(string id);
        public Boolean SuspendStaff(string id);
        public Boolean RecallRetrenchStaff(string id);
        public Boolean RecallSuspendStaff(string id);
        public IEnumerable<Suspend> GetSuspendedStaff();
        public IEnumerable<Retrench> GetRetrenchedStaff();
    }
}
