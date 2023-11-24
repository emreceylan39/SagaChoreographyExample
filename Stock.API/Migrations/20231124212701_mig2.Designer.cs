﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.API.Models.Contexts;

#nullable disable

namespace Stock.API.Migrations
{
    [DbContext(typeof(StockAPIDbContext))]
    [Migration("20231124212701_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Stock.API.Models.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b41f59e4-a58d-448c-a4e6-de3c0f1184a4"),
                            CreatedDate = new DateTime(2023, 11, 25, 0, 27, 1, 505, DateTimeKind.Local).AddTicks(7285),
                            ProductId = new Guid("5e53191f-76ab-4147-a82a-320a1d146e3b"),
                            Quantity = 5
                        },
                        new
                        {
                            Id = new Guid("2f27a87d-6ce8-41ba-8a23-a122c02381c2"),
                            CreatedDate = new DateTime(2023, 11, 25, 0, 27, 1, 505, DateTimeKind.Local).AddTicks(7298),
                            ProductId = new Guid("4072df50-6141-44b2-b5aa-e322a519b172"),
                            Quantity = 55
                        },
                        new
                        {
                            Id = new Guid("4b750210-02ea-4cce-8349-62138757eacd"),
                            CreatedDate = new DateTime(2023, 11, 25, 0, 27, 1, 505, DateTimeKind.Local).AddTicks(7301),
                            ProductId = new Guid("d05a72b2-328f-49f1-9e05-8e2e582f4829"),
                            Quantity = 22
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
