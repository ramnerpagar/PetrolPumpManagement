using Staff_Data.Models;

namespace Staff_Data.Services.Interfaces
{
    public interface ISeniorStaffService
    {
        public IEnumerable<SeniorStaff> GetStaff();
        public SeniorStaff AddStaff(SeniorStaff staff);
        public Boolean UpdateStaff(SeniorStaff staff);
        public Boolean RetrenchStaff(string id);
        public Boolean SuspendStaff(string id);
        public Boolean RecallRetrenchStaff(string id);
        public Boolean RecallSuspendStaff(string id);
        public IEnumerable<Suspend1> GetSuspendedStaff();
        public IEnumerable<Retrench1> GetRetrenchedStaff();
    }
}
