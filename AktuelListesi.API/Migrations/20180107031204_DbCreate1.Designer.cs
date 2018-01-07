﻿// <auto-generated />
using AktuelListesi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AktuelListesi.API.Migrations
{
    [DbContext(typeof(AktuelDbContext))]
    [Migration("20180107031204_DbCreate1")]
    partial class DbCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AktuelListesi.Data.Tables.Aktuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComapnyId");

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ReleasedDate");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Aktuels");
                });

            modelBuilder.Entity("AktuelListesi.Data.Tables.AktuelPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AktuelId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PageImageUrl");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("AktuelId");

                    b.ToTable("AktuelPages");
                });

            modelBuilder.Entity("AktuelListesi.Data.Tables.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AktuelListesi.Data.Tables.Aktuel", b =>
                {
                    b.HasOne("AktuelListesi.Data.Tables.Company", "Company")
                        .WithMany("Aktuels")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("AktuelListesi.Data.Tables.AktuelPage", b =>
                {
                    b.HasOne("AktuelListesi.Data.Tables.Aktuel", "Aktuel")
                        .WithMany("AktuelPages")
                        .HasForeignKey("AktuelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}