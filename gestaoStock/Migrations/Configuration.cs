namespace gestaoStock.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<gestaoStock.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(gestaoStock.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.product.AddOrUpdate(x => x.Id,
       new Models.Product() { Id = 1, Name = "Produto 1", Value=25.34 },
       new Models.Product() { Id = 2, Name = "Produto 2", Value=10 },
       new Models.Product() { Id = 3, Name = "Produto 3", Value=0.15 }
       );

            context.store.AddOrUpdate(x => x.Id,
                new Models.Store()
                {
                    Id = 1,
                    Name="Loja A",
                    Address="Morada A"
                },
                new Models.Store()
                {
                    Id = 2,
                    Name="Loja B",
                    Address="Morada B"
                    
                }
           
                );
        }
    }
}
