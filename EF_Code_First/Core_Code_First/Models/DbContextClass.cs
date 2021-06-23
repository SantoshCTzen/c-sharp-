using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Core_Code_First.Models
{
    class DBContextClass : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Demodb; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                 .HasOne(v => v.Vendor)
                 .WithMany(p => p.Products)
                 .HasForeignKey(p => p.VendorRowId);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.CustomerRowId);

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasIndex(c => c.VendorId).IsUnique();

            });


            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(c => c.CustomerId).IsUnique();

            });

           
        }
    }
}
