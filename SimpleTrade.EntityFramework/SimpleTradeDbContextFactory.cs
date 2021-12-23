using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrade.EntityFramework
{
    public class SimpleTradeDbContextFactory : IDesignTimeDbContextFactory<SimpleTradeDbContext>
    {
        public SimpleTradeDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTradeDbContext>();
            options.UseMySql("server=localhost; port=3306; database=SimpleTradeDB; user=root; password=5u7ud100%");

            return new SimpleTradeDbContext(options.Options);
        }
    }
}
