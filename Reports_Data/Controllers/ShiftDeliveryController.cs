using Microsoft.AspNetCore.Mvc;
using NLog;
using Reports_Data.DBContext;
using Reports_Data.Services;
using ILogger = NLog.ILogger;

namespace Reports_Data.Controllers
{
    [ApiController]
    [Route("Table/[controller]")]
    public class ShiftDeliveryController : Controller
    {
        ShiftDeliveryService shiftDeliveryService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public ShiftDeliveryController(StaffSalaryDBContext staffSalaryDBContext)
        {
            shiftDeliveryService = new ShiftDeliveryService(staffSalaryDBContext);
        }

        [HttpGet]
        public IActionResult ShiftDeliveryData(string shift, DateTime date1)
        {
            try
            {
                return Ok(shiftDeliveryService.ShiftDeliveryData(shift, date1));
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
            
        }
    }
}
