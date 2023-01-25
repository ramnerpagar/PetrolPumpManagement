using Microsoft.AspNetCore.Mvc;
using Staff_Data.Models;

namespace Staff_Data.Repositories.Interfaces
{
    public interface ISeniorStaffRepository
    {
        public IEnumerable<SeniorStaff> GetStaff();
        public SeniorStaff AddStaff(SeniorStaff staff);
        public Boolean UpdateStaff(SeniorStaff staff);
        public Boolean RetrenchStaff([FromRoute] string id);
        public Boolean SuspendStaff([FromRoute] string id);
        public Boolean RecallRetrenchStaff([FromRoute] string id);
        public Boolean RecallSuspendStaff([FromRoute] string id);
        public IEnumerable<Suspend1> GetSuspendedStaff();
        public IEnumerable<Retrench1> GetRetrenchedStaff();
    }
}
