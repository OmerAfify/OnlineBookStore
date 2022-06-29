﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBookStore.Models;

namespace OnlineBookStore.Migrations
{
    [DbContext(typeof(OnlineBookStoreDbContext))]
    [Migration("20220623080737_CreationalDateAddedToBookItem")]
    partial class CreationalDateAddedToBookItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBookStore.Models.BookCategory", b =>
                {
                    b.Property<int>("bookCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bookCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bookCategoryId");

                    b.ToTable("Tb_BookCategory");
                });

            modelBuilder.Entity("OnlineBookStore.Models.BookItem", b =>
                {
                    b.Property<int>("bookItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bookCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("bookItemImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("creationalDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 6, 23, 10, 7, 37, 164, DateTimeKind.Local).AddTicks(7151));

                    b.Property<decimal>("purchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("salesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("bookItemId");

                    b.HasIndex("bookCategoryId");

                    b.ToTable("Tb_BookItem");
                });

            modelBuilder.Entity("OnlineBookStore.Models.Slider", b =>
                {
                    b.Property<int>("sliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sliderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sliderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sliderId");

                    b.ToTable("Tb_Slider");
                });

            modelBuilder.Entity("OnlineBookStore.Models.BookItem", b =>
                {
                    b.HasOne("OnlineBookStore.Models.BookCategory", "bookCategory")
                        .WithMany("bookItems")
                        .HasForeignKey("bookCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
