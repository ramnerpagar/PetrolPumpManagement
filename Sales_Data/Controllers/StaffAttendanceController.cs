using Microsoft.AspNetCore.Mvc;
using Sales_Data.DataContext;
using Sales_Data.Models;
using Pump_Data.Models;
using Sales_Data.Services;
using NLog;
using ILogger = NLog.ILogger;

namespace Sales_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffAttendanceController : Controller
    {
        StaffAttaindanceService staffAttaindanceService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public StaffAttendanceController(SalesDBContext salesDBContext)
        {
            staffAttaindanceService = new StaffAttaindanceService(salesDBContext);
        }

        [HttpGet]
        public IActionResult GetStaffEntry(string tblStaffId,DateTime tblDate)
        {
            try
            {
                return Ok(staffAttaindanceService.GetStaffEntry(tblStaffId, tblDate));
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public IActionResult RemoveStaffEntry(string tblStaffId,DateTime tblDate) 
        {
            bool status = staffAttaindanceService.RemoveStaffEntry(tblStaffId, tblDate);
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Deleted Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Deletion Failed";
                }
                return Ok(jsonResponse);
            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

    }
}
