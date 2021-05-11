﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iCard.Data.Contexts;

namespace iCard.Data.Migrations
{
    [DbContext(typeof(ICardContext))]
    [Migration("20210511220141_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("iCard.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<int>("PlanId")
                        .HasColumnType("integer");

                    b.Property<int>("SettingsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.HasIndex("SettingsId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("iCard.Data.Entities.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CardTransactions")
                        .HasColumnType("integer");

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<bool>("Insurance")
                        .HasColumnType("boolean");

                    b.Property<double>("MaxExchange")
                        .HasColumnType("double precision");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("iCard.Data.Entities.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AppNotifications")
                        .HasColumnType("boolean");

                    b.Property<string>("AppTheme")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<bool>("AutoUpdate")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("GamblingBlock")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("iCard.Data.Entities.TransactionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<double>("TransactionCost")
                        .HasColumnType("double precision");

                    b.Property<string>("TransactionStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("TransactionTarget")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("TransactionHistory");
                });

            modelBuilder.Entity("iCard.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("iCard.Data.Entities.VirtualCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AccountId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("ValidDate")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("VirtualCard");
                });

            modelBuilder.Entity("iCard.Data.Entities.Account", b =>
                {
                    b.HasOne("iCard.Data.Entities.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iCard.Data.Entities.Settings", "Settings")
                        .WithMany()
                        .HasForeignKey("SettingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("iCard.Data.Entities.TransactionHistory", b =>
                {
                    b.HasOne("iCard.Data.Entities.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("iCard.Data.Entities.User", b =>
                {
                    b.HasOne("iCard.Data.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("iCard.Data.Entities.VirtualCard", b =>
                {
                    b.HasOne("iCard.Data.Entities.Account", "Account")
                        .WithMany("VirtualCards")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("iCard.Data.Entities.Account", b =>
                {
                    b.Navigation("Transactions");

                    b.Navigation("VirtualCards");
                });
#pragma warning restore 612, 618
        }
    }
}
