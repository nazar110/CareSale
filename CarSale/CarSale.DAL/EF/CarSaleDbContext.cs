using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CarSale.DAL.Entities;
namespace CarSale.DAL.EF
{
    class CarSaleDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        //public ApplicationContext()
        //{
        //    return Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=carsaledb;Trusted_Connection=True;");
        }
    }
}
