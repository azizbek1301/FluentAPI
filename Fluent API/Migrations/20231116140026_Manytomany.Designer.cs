﻿// <auto-generated />
using Fluent_API.DataAcsess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fluent_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231116140026_Manytomany")]
    partial class Manytomany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fluent_API.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Fluent_API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Fluent_API.Models.PersonCars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarRustamId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("PersonRustamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarRustamId");

                    b.HasIndex("PersonRustamId");

                    b.ToTable("PersonCars");
                });

            modelBuilder.Entity("Fluent_API.Models.PersonCars", b =>
                {
                    b.HasOne("Fluent_API.Models.Car", "Cars")
                        .WithMany("CarPersons")
                        .HasForeignKey("CarRustamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fluent_API.Models.Person", "Persons")
                        .WithMany("PersonCars")
                        .HasForeignKey("PersonRustamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("Fluent_API.Models.Car", b =>
                {
                    b.Navigation("CarPersons");
                });

            modelBuilder.Entity("Fluent_API.Models.Person", b =>
                {
                    b.Navigation("PersonCars");
                });
#pragma warning restore 612, 618
        }
    }
}
