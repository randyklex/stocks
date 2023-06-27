using Microsoft.AspNetCore.Mvc;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("")]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Running.");
        }
    }
}