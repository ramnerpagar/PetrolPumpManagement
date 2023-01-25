using Microsoft.AspNetCore.Mvc;
using NLog;
using Reports_Data.DBContext;
using Reports_Data.Services;
using ILogger = NLog.ILogger;

namespace Reports_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PumpDailyReportController : Controller
    {
        PumpDailyService pumpDailyService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public PumpDailyReportController(StaffSalaryDBContext staffSalaryDBContext)
        {
            pumpDailyService = new PumpDailyService(staffSalaryDBContext);
        }

        [HttpGet]
        public IActionResult PumpDailyReport(string shift, DateTime date)
        {
            try
            {
                return Ok(pumpDailyService.GetPumpDailyReport(shift, date));
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
    }
}
