using Microsoft.AspNetCore.Mvc;
using NLog;
using Reports_Data.DBContext;
using Reports_Data.Services;
using Reports_Data.Services.Interfaces;
using ILogger = NLog.ILogger;


namespace Reports_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffSalaryController : Controller
    {
        StaffSalaryService staffSalaryService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();


        public StaffSalaryController(StaffSalaryDBContext staffSalaryDBContext)
        {
            staffSalaryService = new StaffSalaryService(staffSalaryDBContext);
        }

        [HttpGet]
        public IActionResult CalculateSalary(DateTime date1, DateTime date2)
        {
            try
            {
                return Ok(staffSalaryService.CalculateSalary(date1,date2));
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
    }
}
