namespace Stocks.Data.Models
{
    public class JournalEntry
    {
        public JournalEntry()
        { }
        
        public Guid JournalId { get; set; }

        public Guid LineId { get; set; }

        public DateTime PostingDate { get; set; }

        public string Memo { get; set; }

        public string Account { get; set; }

        public string NormalBalance { get; set; }

        public string? Ticker { get; set; } 

        public string Status { get; set; }

        public decimal Amount { get; set; }   

        public bool IsDebit { get; set; }

        public decimal? Shares { get; set; }

        public decimal? PricePerShare { get; set; }
    }
}