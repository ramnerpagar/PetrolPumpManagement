namespace Reports_Data.Services.Interfaces
{
    public interface IPumpDailyService
    {
        public IEnumerable<Object> GetPumpDailyReport(string shift, DateTime date);

    }
}
