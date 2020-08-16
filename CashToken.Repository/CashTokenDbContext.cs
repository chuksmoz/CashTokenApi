using CashToken.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashToken.Repository
{
    public class CashTokenDbContext: DbContext
    {
        public CashTokenDbContext(DbContextOptions<CashTokenDbContext> options) : base(options)
        {
                
        }

        public DbSet<TransactionToken> TransactionTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
