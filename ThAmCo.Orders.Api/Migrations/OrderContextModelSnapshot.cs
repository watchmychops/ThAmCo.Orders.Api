﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Orders.Api.Data;

#nullable disable

namespace ThAmCo.Orders.Api.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("ThAmCo.Orders.Api.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Notes = "Please deliver to garage",
                            Status = 0,
                            SubmittedDate = new DateTime(2023, 7, 22, 10, 30, 10, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 22, 10, 30, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Notes = "Leave at front desk",
                            Status = 1,
                            SubmittedDate = new DateTime(2023, 7, 23, 11, 15, 30, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 23, 11, 15, 30, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Notes = "Ring bell on arrival",
                            Status = 2,
                            SubmittedDate = new DateTime(2023, 7, 24, 12, 45, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 24, 12, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 4,
                            Notes = "Contact on mobile before delivery",
                            Status = 0,
                            SubmittedDate = new DateTime(2023, 7, 25, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 25, 9, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 5,
                            Notes = "Deliver after 5 PM",
                            Status = 1,
                            SubmittedDate = new DateTime(2023, 7, 26, 14, 20, 10, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 26, 14, 20, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CustomerId = 6,
                            Notes = "Gate code is 1234",
                            Status = 2,
                            SubmittedDate = new DateTime(2023, 7, 27, 10, 50, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 27, 10, 50, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CustomerId = 7,
                            Notes = "No signature required",
                            Status = 0,
                            SubmittedDate = new DateTime(2023, 7, 28, 16, 5, 20, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 28, 16, 5, 20, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CustomerId = 8,
                            Notes = "Call on arrival, allergic to dogs",
                            Status = 1,
                            SubmittedDate = new DateTime(2023, 7, 29, 13, 30, 45, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 29, 13, 30, 45, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CustomerId = 9,
                            Notes = "Urgent delivery requested",
                            Status = 2,
                            SubmittedDate = new DateTime(2023, 7, 30, 8, 15, 15, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 30, 8, 15, 15, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CustomerId = 10,
                            Notes = "Please package discreetly",
                            Status = 0,
                            SubmittedDate = new DateTime(2023, 7, 31, 17, 40, 5, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2023, 7, 31, 17, 40, 5, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ThAmCo.Orders.Api.Data.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 10,
                            UnitPrice = 10.32
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 3,
                            Quantity = 1,
                            UnitPrice = 200.0
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 2,
                            ProductId = 4,
                            Quantity = 2,
                            UnitPrice = 22.0
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 2,
                            ProductId = 5,
                            Quantity = 1,
                            UnitPrice = 50.0
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 3,
                            ProductId = 6,
                            Quantity = 3,
                            UnitPrice = 35.75
                        },
                        new
                        {
                            Id = 7,
                            OrderId = 3,
                            ProductId = 7,
                            Quantity = 2,
                            UnitPrice = 18.199999999999999
                        },
                        new
                        {
                            Id = 8,
                            OrderId = 3,
                            ProductId = 1,
                            Quantity = 1,
                            UnitPrice = 10.32
                        },
                        new
                        {
                            Id = 9,
                            OrderId = 4,
                            ProductId = 8,
                            Quantity = 1,
                            UnitPrice = 42.5
                        },
                        new
                        {
                            Id = 10,
                            OrderId = 5,
                            ProductId = 9,
                            Quantity = 2,
                            UnitPrice = 55.0
                        },
                        new
                        {
                            Id = 11,
                            OrderId = 5,
                            ProductId = 3,
                            Quantity = 1,
                            UnitPrice = 200.0
                        },
                        new
                        {
                            Id = 12,
                            OrderId = 6,
                            ProductId = 10,
                            Quantity = 4,
                            UnitPrice = 60.0
                        },
                        new
                        {
                            Id = 13,
                            OrderId = 7,
                            ProductId = 2,
                            Quantity = 3,
                            UnitPrice = 15.5
                        },
                        new
                        {
                            Id = 14,
                            OrderId = 7,
                            ProductId = 4,
                            Quantity = 1,
                            UnitPrice = 22.0
                        },
                        new
                        {
                            Id = 15,
                            OrderId = 7,
                            ProductId = 6,
                            Quantity = 2,
                            UnitPrice = 35.75
                        },
                        new
                        {
                            Id = 16,
                            OrderId = 8,
                            ProductId = 5,
                            Quantity = 1,
                            UnitPrice = 50.0
                        },
                        new
                        {
                            Id = 17,
                            OrderId = 8,
                            ProductId = 7,
                            Quantity = 1,
                            UnitPrice = 18.199999999999999
                        },
                        new
                        {
                            Id = 18,
                            OrderId = 9,
                            ProductId = 1,
                            Quantity = 2,
                            UnitPrice = 10.32
                        },
                        new
                        {
                            Id = 19,
                            OrderId = 9,
                            ProductId = 8,
                            Quantity = 1,
                            UnitPrice = 42.5
                        },
                        new
                        {
                            Id = 20,
                            OrderId = 9,
                            ProductId = 10,
                            Quantity = 3,
                            UnitPrice = 60.0
                        },
                        new
                        {
                            Id = 21,
                            OrderId = 10,
                            ProductId = 9,
                            Quantity = 1,
                            UnitPrice = 55.0
                        });
                });

            modelBuilder.Entity("ThAmCo.Orders.Api.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lamp that is very super cool",
                            Name = "Standing Lamp"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A case for your books",
                            Name = "Bookcase"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Comfortable and adjustable chair perfect for long working hours",
                            Name = "Ergonomic Chair"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Sleek and responsive keyboard with long battery life",
                            Name = "Wireless Keyboard"
                        },
                        new
                        {
                            Id = 5,
                            Description = "High-quality audio with noise cancellation feature",
                            Name = "Bluetooth Headphones"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Stylish watch with fitness tracking and notifications",
                            Name = "Smart Watch"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Insulated bottle to keep your drinks hot or cold for hours",
                            Name = "Water Bottle"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Durable and spacious backpack, ideal for travel or daily use",
                            Name = "Backpack"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Elegant lamp with adjustable brightness for reading or work",
                            Name = "Table Lamp"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Keep your workspace tidy with this multi-compartment organiser",
                            Name = "Desk Organiser"
                        });
                });

            modelBuilder.Entity("ThAmCo.Orders.Api.Data.OrderDetail", b =>
                {
                    b.HasOne("ThAmCo.Orders.Api.Data.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThAmCo.Orders.Api.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ThAmCo.Orders.Api.Data.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
