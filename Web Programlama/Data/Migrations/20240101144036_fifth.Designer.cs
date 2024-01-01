﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Web_Programlama.Context;

#nullable disable

namespace Web_Programlama.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240101144036_fifth")]
    partial class fifth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Web_Programlama.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Web_Programlama.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("DidGetAppointed")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SeatCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Web_Programlama.Models.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PlaneId")
                        .HasColumnType("integer");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PlaneId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Web_Programlama.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("boolean");

                    b.Property<int?>("PlaneId")
                        .HasColumnType("integer");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlaneId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("Web_Programlama.Models.Route", b =>
                {
                    b.HasOne("Web_Programlama.Models.Plane", "Plane")
                        .WithMany()
                        .HasForeignKey("PlaneId");

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("Web_Programlama.Models.Seat", b =>
                {
                    b.HasOne("Web_Programlama.Models.Plane", null)
                        .WithMany("Seats")
                        .HasForeignKey("PlaneId");
                });

            modelBuilder.Entity("Web_Programlama.Models.Plane", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
