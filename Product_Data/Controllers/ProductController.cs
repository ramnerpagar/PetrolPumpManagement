using Microsoft.AspNetCore.Mvc;
using Product_Data.DataContext;
using Product_Data.Models;
using Product_Data.Services;
using Pump_Data.Models;
using NLog;
using ILogger = NLog.ILogger;


namespace Product_Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        ProductService productService;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ProductController(ProductDBContext productDBContext) 
        {
            productService = new ProductService(productDBContext);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {   try
            {
                return Ok(productService.GetProducts());
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductCost obj)
        {
            try
            {
                Console.WriteLine("hello");
                bool status = productService.UpdatesProduct(obj.Cost1,obj.Cost2,obj.Cost3,obj.Cost4);
                JsonResponse jsonResponse = new JsonResponse();
                if(status)
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Update Successful";
                }
                else
                {
                    jsonResponse.Result = true;
                    jsonResponse.Message = "Update Failed";
                }
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
