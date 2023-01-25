using Microsoft.AspNetCore.Mvc;
using Staff_Data.DataContext;
using Staff_Data.Models;
using Staff_Data.Services;
using Pump_Data.Models;
using ILogger = NLog.ILogger;
using NLog;

namespace Staff_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecurityStaffController : Controller
    {
        private SecurityStaffService staffService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public SecurityStaffController(StaffDBContext dbContext)
        {
            staffService = new SecurityStaffService(dbContext);
        }

        [HttpGet]
        public IActionResult GetStaff()
        {
            try
            {
                return Ok(staffService.GetStaff());
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult AddStaff(SecurityStaff staff)
        {
            try
            {
                return Ok(staffService.AddStaff(staff));
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public IActionResult UpdateStaff(SecurityStaff staff)
        {
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (staffService.UpdateStaff(staff))
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Updated Successfully";
                }else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Updation Failed";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        [Route("retrench/{id}")]
        public IActionResult RetrenchStaff([FromRoute] string id)
        {
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (staffService.RetrenchStaff(id))
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Retreched Staff Successfully";
                }else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Retrenched Staff Failed";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("suspend/{id}")]
        public IActionResult SuspendStaff([FromRoute] string id)
        {
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (staffService.SuspendStaff(id))
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Suspend Staff Successfully";
                }else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Suspend Staff Failed";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        [Route("recallRetrench/{id}")]
        public IActionResult RecallRetrenchStaff([FromRoute] string id)
        {
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (staffService.RecallRetrenchStaff(id))
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Recall Retrenched Staff Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Recall Retrenched Staff Failed";
                }
                return Ok(jsonResponse);
            }
            catch(Exception ex) 
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        [Route("recallSuspend/{id}")]
        public IActionResult RecallSuspendStaff([FromRoute] string id)
        {
            try
            {
                JsonResponse jsonResponse = new JsonResponse();
                if (staffService.RecallSuspendStaff(id))
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Recall Suspended Staff Successfully";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Recall Suspended Staff Failed";
                }
                return Ok(jsonResponse);
            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("getSuspendedStaffs")]
        public IActionResult GetSuspendedStaff()
        {
            try
            {
                return Ok(staffService.GetSuspendedStaff());
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("getRetrenchedStaffs")]
        public IActionResult GetRetrenchedStaff()
        {
            try
            {
                return Ok(staffService.GetRetrenchedStaff());
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
    }
}
