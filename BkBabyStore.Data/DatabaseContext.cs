﻿using Microsoft.EntityFrameworkCore;
using BkBabyStore.Entities;


namespace BkBabyStore.Data
{
   public class DatabaseContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Burası veritabanı yapılandırma ayarlarını yapabileceğimiz metot
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=BkBabyStore; integrated security=true;");
            //optionsBuilder.UseInMemoryDatabase("NetCoreMvcProjeUygulamasi");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Burası veritabanımız oluştuktan sonra model classları ile ilgili işlemlerin yapılabileceği metot
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Phone = "",
                    Email = "admin@projeuygulamasi.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "admin",
                    Surname = "admin",
                    Password = "123"
                }
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
