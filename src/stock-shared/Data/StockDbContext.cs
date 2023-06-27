using System;
using System.Collections.Generic;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Stocks.Data.Models;

namespace Stocks.Data
{
    public class StockDbContext : DbContext
    {
        private readonly ILogger<StockDbContext> logger;
        private readonly IConfiguration configuration;

        public StockDbContext(ILogger<StockDbContext> logger, IConfiguration config)
        {
            this.logger = logger;
            this.configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            string connectionString = configuration.GetConnectionString("db");
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder(connectionString);
            sqlBuilder.Password = configuration["DbPassword"];

            optionsBuilder.UseSqlServer(sqlBuilder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JournalEntry>(entity =>
            {
                entity.ToView("view_journal_entry");
                entity.HasKey(pk => new {pk.JournalId, pk.LineId});
                entity.Property(e => e.JournalId).HasColumnName("journal_id");
                entity.Property(e => e.LineId).HasColumnName("line_id");
                entity.Property(e => e.PostingDate).HasColumnName("posting_dt");
                entity.Property(e => e.Memo).HasColumnName("memo");
                entity.Property(e => e.Account).HasColumnName("account");
                entity.Property(e => e.NormalBalance).HasColumnName("normal_balance");
                entity.Property(e => e.Ticker).HasColumnName("ticker");
                entity.Property(e => e.Amount).HasColumnName("amount");
                entity.Property(e => e.IsDebit).HasColumnName("is_debit");
                entity.Property(e => e.Shares).HasColumnName("shares");
                entity.Property(e => e.PricePerShare).HasColumnName("price_per_share");
            });
        }
    }
}