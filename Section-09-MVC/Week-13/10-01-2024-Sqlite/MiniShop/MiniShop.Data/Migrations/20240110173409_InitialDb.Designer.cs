﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data;

#nullable disable

namespace MiniShop.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240110173409_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("MiniShop.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4454),
                            Description = "TV kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4471),
                            Name = "Televizyon",
                            Url = "televizyon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4482),
                            Description = "Bilgisayar kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4483),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4484),
                            Description = "Elektronik Eşya kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4485),
                            Name = "Elektronik Eşya",
                            Url = "elektronik-esya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4486),
                            Description = "Beyaz Eşya kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4486),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4487),
                            Description = "Telefon kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(4487),
                            Name = "Telefon",
                            Url = "telefon"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.CategoryProduct", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProducts", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 11
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6441),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6449),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6456),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6456),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da Harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6458),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6459),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6460),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6461),
                            Name = "Xiaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xiaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6462),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6462),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6464),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6464),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16 Gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6466),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6466),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6467),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6468),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6469),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6469),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6470),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6471),
                            Name = "Xiaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xiaomi-dijital-baskul"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6472),
                            ImageUrl = "11.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 20, 34, 8, 892, DateTimeKind.Local).AddTicks(6472),
                            Name = "Blaupunkt AC69 Led TV",
                            Price = 9800m,
                            Properties = "Android tv",
                            Url = "blaupunkt-ac69-led-tv"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.CategoryProduct", b =>
                {
                    b.HasOne("MiniShop.Entity.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("MiniShop.Entity.Product", b =>
                {
                    b.Navigation("CategoryProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
