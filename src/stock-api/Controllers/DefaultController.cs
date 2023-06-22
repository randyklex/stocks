using Microsoft.AspNetCore.Mvc;

namespace Stocks.Controllers
{
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return Ok("Running.");
        }
    }
}