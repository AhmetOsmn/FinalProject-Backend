using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tablolari ile proje classlarini iliskilendirir.
    public class NorthwindContext : DbContext
    {
        //Projenin hangi veritabani ile iliskili oldugunu belirten metot.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"); // '\' kullanirken @ kullanmamiz gerekir. Yoksa '\' karakterinin ozel anlami vardir.
        }

        public DbSet<Product> Products { get; set; }    //bendeki Product sinifi veritabanindaki Products tablosune denk geliyor.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
