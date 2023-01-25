namespace Reports_Data.Services.Interfaces
{
    public interface IShiftDeliveryService
    {
        public IEnumerable<Object> ShiftDeliveryData(string shift, DateTime date1);
    }
}
