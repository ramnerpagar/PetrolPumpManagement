using Microsoft.AspNetCore.Mvc;
using Staff_Data.DataContext;
using Staff_Data.Models;
using Staff_Data.Repositories;
using Staff_Data.Services.Interfaces;

namespace Staff_Data.Services
{
    public class StaffService : IStaffService
    {
        StaffRepository repository;
        public StaffService(StaffDBContext dbContext)
        {
            repository = new StaffRepository(dbContext);
        }
        public IEnumerable<Staff> GetStaff()
        {
            return repository.GetStaff();
        }
        public Staff AddStaff(Staff staff)
        {
            return repository.AddStaff(staff);
        }
        public Boolean UpdateStaff(Staff staff)
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
        public IEnumerable<Suspend> GetSuspendedStaff()
        {
            return repository.GetSuspendedStaff();
        }
        public IEnumerable<Retrench> GetRetrenchedStaff()
        {
            return repository.GetRetrenchedStaff();
        }
    }
}
