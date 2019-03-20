﻿using System.Data.Entity;
using KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext: DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
