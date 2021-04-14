﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using money_minder.Models;

namespace money_minder.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210414023419_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("money_minder.Models.AccountBalance", b =>
                {
                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Total");

                    b.ToTable("AccountBalances");
                });

            modelBuilder.Entity("money_minder.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PaycheckId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BillId");

                    b.HasIndex("PaycheckId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("money_minder.Models.BillHistory", b =>
                {
                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PaidDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Total");

                    b.HasIndex("BillId");

                    b.ToTable("BillHistories");
                });

            modelBuilder.Entity("money_minder.Models.Paycheck", b =>
                {
                    b.Property<int>("PaycheckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("From")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PaycheckId");

                    b.ToTable("Paychecks");
                });

            modelBuilder.Entity("money_minder.Models.Bill", b =>
                {
                    b.HasOne("money_minder.Models.Paycheck", null)
                        .WithMany("PlannedBills")
                        .HasForeignKey("PaycheckId");
                });

            modelBuilder.Entity("money_minder.Models.BillHistory", b =>
                {
                    b.HasOne("money_minder.Models.Bill", "Source")
                        .WithMany("Histories")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}