using Microsoft.AspNetCore.Mvc;
using NLog;
using Reports_Data.DBContext;
using Reports_Data.Services;
using ILogger = NLog.ILogger;

namespace Reports_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PumpAllSalesController : Controller
    {
        PumpAllSalesService pumpAllSalesService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public PumpAllSalesController(StaffSalaryDBContext staffSalaryDBContext)
        {
            pumpAllSalesService = new PumpAllSalesService(staffSalaryDBContext);
        }

        [HttpGet]
        public IActionResult GetPumpSalesById(int id)
        {
            try
            {
                return Ok(pumpAllSalesService.GetPumpSalesById(id));
            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
    }
}
