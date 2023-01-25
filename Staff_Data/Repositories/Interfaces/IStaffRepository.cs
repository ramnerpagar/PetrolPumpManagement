using Microsoft.AspNetCore.Mvc;
using Staff_Data.Models;

namespace Staff_Data.Repositories.Interfaces
{
    public interface IStaffRepository
    {
        public IEnumerable<Staff> GetStaff();
        public Staff AddStaff(Staff staff);
        public Boolean UpdateStaff(Staff staff);
        public Boolean RetrenchStaff([FromRoute] string id);
        public Boolean SuspendStaff([FromRoute] string id);
        public Boolean RecallRetrenchStaff([FromRoute] string id);
        public Boolean RecallSuspendStaff([FromRoute] string id);
        public IEnumerable<Suspend> GetSuspendedStaff();
        public IEnumerable<Retrench> GetRetrenchedStaff();
    }
}
