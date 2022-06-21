using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gestaoStock.Models;

namespace gestaoStock.Data
{
    public class gestaoStockContext : DbContext
    {
        public gestaoStockContext (DbContextOptions<gestaoStockContext> options)
            : base(options)
        {
        }

        public DbSet<gestaoStock.Models.Product>? Product { get; set; }

        public DbSet<gestaoStock.Models.Store>? Store { get; set; }

        public DbSet<gestaoStock.Models.StockItem>? StockItem { get; set; }
    }
}
