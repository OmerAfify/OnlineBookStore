using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class OnlineBookStoreDbContext : IdentityDbContext<ApplicationIdentiyUser>
    {
        public OnlineBookStoreDbContext() { }
        public OnlineBookStoreDbContext(DbContextOptions<OnlineBookStoreDbContext> options):base(options) { }

        public DbSet<BookItem> Tb_BookItem { get; set; }
        public DbSet<BookCategory> Tb_BookCategory { get; set; }
        public DbSet<Slider> Tb_Slider { get; set; }
        public DbSet<Discount> Tb_Discount { get; set; }
        public DbSet<Slider> Tb_BookItemsImages { get; set; }
      
        public DbSet<Order> Tb_Orders { get; set; }
        public DbSet<OrderDetails> Tb_OrderDetails { get; set; }
        public DbSet<OrderedItem> Tb_OrderedItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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


            //Orders
            modelBuilder.Entity<Order>().HasOne(u => u.user).WithMany();
            modelBuilder.Entity<OrderDetails>().HasOne(o=>o.order).WithOne(od=>od.orderDetails);
            modelBuilder.Entity<OrderedItem>().HasKey(o=>new {o.orderDetailsId, o.bookItemId });

       


        }
    }
}