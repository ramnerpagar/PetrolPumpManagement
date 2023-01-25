using Microsoft.AspNetCore.Mvc;
using NLog;
using Pump_Data.DataContext;
using Pump_Data.Models;
using Pump_Data.Services;
using ILogger = NLog.ILogger;
namespace Pump_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PumpManagementController : Controller
    {
        PumpManagementService pumpManagementService;
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public PumpManagementController(PumpDBContext pumpDBContext)
        {
            pumpManagementService = new PumpManagementService(pumpDBContext);
        }

        [HttpGet]
        public IActionResult GetAllPumps()
        {
            try
            {
                return Ok(pumpManagementService.GetAllPumps());
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult CreatePump(PumpManagement Pump)
        {
            try
            {
                bool status = pumpManagementService.CreatePump(Pump);
                JsonResponse jsonResponse= new JsonResponse();
                if (status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Pump Added Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Pump Addition Failed";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public IActionResult UpdatePump(short PumpId,PumpManagement NewPump)
        {
            try
            {
                bool status = pumpManagementService.UpdatePump(PumpId, NewPump);
                JsonResponse jsonResponse = new JsonResponse();
                if (status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Pump Updated Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Pump with Id" + PumpId + "Is Not Present";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public IActionResult DeletePump(short PumpId)
        {
            try
            {
                bool status = pumpManagementService.DeletePump(PumpId);
                JsonResponse jsonResponse = new JsonResponse();
                if (status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Pump Deleted Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Pump with Id" + PumpId + "Is Not Present";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
    }
}
