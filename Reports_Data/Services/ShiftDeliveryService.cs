using Reports_Data.Repositories;
using Reports_Data.Services.Interfaces;
using Reports_Data.DBContext;
namespace Reports_Data.Services
{
    public class ShiftDeliveryService : IShiftDeliveryService
    {
        ShiftDeliveryRepository shiftDeliveryRepository;
        public ShiftDeliveryService(StaffSalaryDBContext staffSalaryDBContext)
        {
            shiftDeliveryRepository = new ShiftDeliveryRepository(staffSalaryDBContext);

        }
        public IEnumerable<Object> ShiftDeliveryData(string shift, DateTime date1)
        {
            return shiftDeliveryRepository.ShiftDeliveryData(shift, date1);
        }
    }
}
