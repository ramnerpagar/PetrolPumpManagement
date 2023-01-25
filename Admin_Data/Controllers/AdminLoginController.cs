using Admin_Data.DataContext;
using Admin_Data.Models;
using Admin_Data.Services;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Pump_Data.Models;
using ILogger = NLog.ILogger;

namespace Admin_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminLoginController : Controller
    {
        AdminLoginService adminLoginService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public AdminLoginController(AdminDBContext adminDBContext)
        {
            adminLoginService = new AdminLoginService(adminDBContext);
        }
        [HttpPost]
        public IActionResult AdminLogin(AdminLogin Details)
        {
            try
            {
                bool status = adminLoginService.AdminLogin(Details);
                JsonResponse jsonResponse = new JsonResponse(); 
                if (status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Login Sucess";
                }
                else
                {
                    jsonResponse.Result = false;
                    jsonResponse.Message = "Login failed";
                }
                logger.Info("sucess");
                return Ok(jsonResponse);
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

    }
}
