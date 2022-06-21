using System.Data.Entity;

namespace gestaoStock.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {

        }

        public DbSet<Product> product { get; set; } // My domain models
        public DbSet<Store> store { get; set; }// My domain models
    }
   
}
