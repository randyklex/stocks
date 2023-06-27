using Microsoft.AspNetCore.Mvc;

using Stocks.Data;
using Stocks.Data.Models;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JournalEntryController : ControllerBase
    {
        private readonly JournalRepository repository;
        private readonly ILogger<JournalEntryController> logger;

        public JournalEntryController(ILogger<JournalEntryController> logger, JournalRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet(Name = "GetJournalEntries")]
        public IEnumerable<JournalEntry> Get()
        {
            //JournalEntry[] items = new JournalEntry[1];
            //items[0] = new JournalEntry();
            //return items;

            return repository.Get((je) => je.PostingDate <= DateTime.Parse("2019-06-01") );
        }
    }
}