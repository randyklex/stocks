using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
        
        string connectionString = configuration["DB_CONNECTION_STRING"];


        optionsBuilder.UseSqlServer()
    }
}