using Microsoft.EntityFrameworkCore;
using SimpleTrade.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrade.EntityFramework
{
    public class SimpleTradeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        public SimpleTradeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
