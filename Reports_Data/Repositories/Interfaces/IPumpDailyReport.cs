namespace Reports_Data.Repositories.Interfaces
{
    public interface IPumpDailyReport
    {
        public IEnumerable<Object> GetPumpDailyReport(string shift, DateTime date);
    }
}
