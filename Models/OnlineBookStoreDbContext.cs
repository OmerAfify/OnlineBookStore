﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class OnlineBookStoreDbContext : DbContext
    {
        public OnlineBookStoreDbContext() { }
        public OnlineBookStoreDbContext(DbContextOptions<OnlineBookStoreDbContext> options):base(options) { }

        public DbSet<BookItem> Tb_BookItem { get; set; }
        public DbSet<BookCategory> Tb_BookCategory { get; set; }
        public DbSet<Slider> Tb_Slider { get; set; }
        public DbSet<Discount> Tb_Discount { get; set; }
        public DbSet<Slider> Tb_BookItemsImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1 to M relationship BookCategory and BookItem
            modelBuilder.Entity<BookItem>()
                .HasOne(bi => bi.bookCategory)
                .WithMany(bc => bc.bookItems)
                .OnDelete(DeleteBehavior.Cascade);

            //Creational Date column for BookItem
            modelBuilder.Entity<BookItem>()
             .Property(b => b.creationalDate)
            .HasDefaultValueSql("getdate()");


            //Date column for Discount of BookItem
            modelBuilder.Entity<Discount>()
             .Property(b => b.discountStartingDate)
            .HasDefaultValueSql("getdate()");

        }
    }
}