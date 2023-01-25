using Reports_Data.Models;

namespace Reports_Data.Repositories.Interfaces
{
    public interface IShiftDeliveryRepository
    {
        public IEnumerable<Object> ShiftDeliveryData(string shift, DateTime date1);
    }
}
