using Microsoft.AspNetCore.Mvc;
using Staff_Data.Models;

namespace Staff_Data.Repositories.Interfaces
{
    public interface ISecurityRepository
    {
        public IEnumerable<SecurityStaff> GetStaff();
        public SecurityStaff AddStaff(SecurityStaff staff);
        public Boolean UpdateStaff(SecurityStaff staff);
        public Boolean RetrenchStaff([FromRoute] string id);
        public Boolean SuspendStaff([FromRoute] string id);
        public Boolean RecallRetrenchStaff([FromRoute] string id);
        public Boolean RecallSuspendStaff([FromRoute] string id);
        public IEnumerable<Suspend2> GetSuspendedStaff();
        public IEnumerable<Retrench2> GetRetrenchedStaff();
    }
}
