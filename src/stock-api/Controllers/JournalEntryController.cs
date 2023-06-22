using Microsoft.AspNetCore.Mvc;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JournalEntryController : ControllerBase
    {
        private readonly ILogger<JournalEntryController> logger;

        public JournalEntryController(ILogger<JournalEntryController> logger)
        {
            this.logger = logger;
        }
    }
}