using Staff_Data.Models;

namespace Staff_Data.Services.Interfaces
{
    public interface ISecurityService
    {
        public IEnumerable<SecurityStaff> GetStaff();
        public SecurityStaff AddStaff(SecurityStaff staff);
        public Boolean UpdateStaff(SecurityStaff staff);
        public Boolean RetrenchStaff(string id);
        public Boolean SuspendStaff(string id);
        public Boolean RecallRetrenchStaff(string id);
        public Boolean RecallSuspendStaff(string id);
        public IEnumerable<Suspend2> GetSuspendedStaff();
        public IEnumerable<Retrench2> GetRetrenchedStaff();
    }
}
