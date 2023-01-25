using Microsoft.AspNetCore.Mvc;
using Staff_Data.DataContext;
using Staff_Data.Models;
using Staff_Data.Repositories;
using Staff_Data.Services.Interfaces;

namespace Staff_Data.Services
{
    public class SeniorStaffService : ISeniorStaffService
    {
        SeniorStaffRepository repository;
        public SeniorStaffService(StaffDBContext dbContext)
        {
            repository = new SeniorStaffRepository(dbContext);
        }
        public IEnumerable<SeniorStaff> GetStaff()
        {
            return repository.GetStaff();
        }
        public SeniorStaff AddStaff(SeniorStaff staff)
        {
            return repository.AddStaff(staff);
        }
        public Boolean UpdateStaff(SeniorStaff staff)
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
        public IEnumerable<Suspend1> GetSuspendedStaff()
        {
            return repository.GetSuspendedStaff();
        }
        public IEnumerable<Retrench1> GetRetrenchedStaff()
        {
            return repository.GetRetrenchedStaff();
        }
    }
}
