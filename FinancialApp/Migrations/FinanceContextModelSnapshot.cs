﻿// <auto-generated />
using System;
using FinancialApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinancialApp.Migrations
{
    [DbContext(typeof(FinanceContext))]
    partial class FinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinancialApp.Models.FinanceContext+Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balance");

                    b.Property<int>("DailyBudget");

                    b.Property<bool>("DebitOrCredit");

                    b.Property<int>("MonthlyBudget");

                    b.Property<int>("Overdraft");

                    b.Property<int>("UserID");

                    b.Property<int>("WeeklyBudget");

                    b.Property<int>("YearlyBudget");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FinancialApp.Models.FinanceContext+Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("FromAccountID");

                    b.Property<bool>("IsRecurring");

                    b.Property<int>("ToAccountID");

                    b.HasKey("TransactionID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FinancialApp.Models.FinanceContext+User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DailyBudget");

                    b.Property<int>("MonthlyBudget");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<int>("WeeklyBudget");

                    b.Property<int>("YearlyBudget");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}