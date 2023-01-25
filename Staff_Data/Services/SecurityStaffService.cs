using Microsoft.AspNetCore.Mvc;
using Staff_Data.DataContext;
using Staff_Data.Models;
using Staff_Data.Repositories;

namespace Staff_Data.Services
{
    public class SecurityStaffService
    {
        SecurityStaffRepository repository;
        public SecurityStaffService(StaffDBContext dbContext)
        {
            repository = new SecurityStaffRepository(dbContext);
        }
        public IEnumerable<SecurityStaff> GetStaff()
        {
            return repository.GetStaff();
        }
        public SecurityStaff AddStaff(SecurityStaff staff)
        {
            return repository.AddStaff(staff);
        }
        public Boolean UpdateStaff(SecurityStaff staff)
        {
            return repository.UpdateStaff(staff);
        }
        public Boolean RetrenchStaff(string id)
        {
            return repository.RetrenchStaff(id);
        }
        public Boolean SuspendStaff([FromRoute] string id)
        {
            return repository.SuspendStaff(id);
        }
        public Boolean RecallRetrenchStaff(string id)
        {
            return repository.RecallRetrenchStaff(id);
        }
        public Boolean RecallSuspendStaff(string id)
        {
            return repository.RecallSuspendStaff(id);
        }
        public IEnumerable<Suspend2> GetSuspendedStaff()
        {
            return repository.GetSuspendedStaff();
        }
        public IEnumerable<Retrench2> GetRetrenchedStaff()
        {
            return repository.GetRetrenchedStaff();
        }
    }
}
