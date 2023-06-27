using Stocks.Data.Models;

namespace Stocks.Data
{
    public class JournalRepository : GenericRepository<JournalEntry>
    {
        public JournalRepository(StockDbContext db)
        : base (db)
        { }
    }
}