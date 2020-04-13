using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PressCompany.Advertisement.Model;

namespace PressCompany.Advertisement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertisementRequestController : ControllerBase
    {
        
        private readonly ILogger<AdvertisementRequestController> _logger;
        
        public AdvertisementRequestController(ILogger<AdvertisementRequestController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost("/api/advertisements")]
        public ActionResult<Opportunity> AddProduct(AdvertisementRequest request)
        {
            Opportunity opportunity = new Opportunity();
            return opportunity;
        }
        
        
    }
}