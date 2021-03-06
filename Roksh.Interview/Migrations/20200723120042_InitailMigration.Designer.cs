﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Roksh.Interview.Repositories;

namespace Roksh.Interview.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200723120042_InitailMigration")]
    partial class InitailMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Roksh.Interview.Models.Pack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PackStateId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackStateId");

                    b.HasIndex("UserId");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("Roksh.Interview.Models.PackProduct", b =>
                {
                    b.Property<int>("PackId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("PackId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("PackProducts");
                });

            modelBuilder.Entity("Roksh.Interview.Models.PackState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HungarianMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PackStates");
                });

            modelBuilder.Entity("Roksh.Interview.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Roksh.Interview.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Roksh.Interview.Models.Pack", b =>
                {
                    b.HasOne("Roksh.Interview.Models.PackState", "PackState")
                        .WithMany()
                        .HasForeignKey("PackStateId");

                    b.HasOne("Roksh.Interview.Models.User", null)
                        .WithMany("PackList")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Roksh.Interview.Models.PackProduct", b =>
                {
                    b.HasOne("Roksh.Interview.Models.Pack", "Pack")
                        .WithMany("PackProducts")
                        .HasForeignKey("PackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Roksh.Interview.Models.Product", "Product")
                        .WithMany("PackProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
