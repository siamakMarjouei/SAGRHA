﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAGRHA.API.Data;

namespace SAGRHA.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191018041432_RelativeRelations")]
    partial class RelativeRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SAGRHA.API.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AFP");

                    b.Property<string>("Address");

                    b.Property<string>("CUA");

                    b.Property<string>("Cell");

                    b.Property<string>("DNI");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("PlaceOfBirth");

                    b.Property<string>("Profession");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SAGRHA.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("SAGRHA.API.Models.RelationTypeCatalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("RelationType");

                    b.Property<int>("RelativeId");

                    b.HasKey("Id");

                    b.HasIndex("RelativeId")
                        .IsUnique();

                    b.ToTable("RelationTypes");
                });

            modelBuilder.Entity("SAGRHA.API.Models.Relative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Dni");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Relatives");
                });

            modelBuilder.Entity("SAGRHA.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Gender");

                    b.Property<string>("Introduction");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LookingFor");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SAGRHA.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("SAGRHA.API.Models.Photo", b =>
                {
                    b.HasOne("SAGRHA.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SAGRHA.API.Models.RelationTypeCatalog", b =>
                {
                    b.HasOne("SAGRHA.API.Models.Relative", "Relative")
                        .WithOne("RelationTypeCatalogId")
                        .HasForeignKey("SAGRHA.API.Models.RelationTypeCatalog", "RelativeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SAGRHA.API.Models.Relative", b =>
                {
                    b.HasOne("SAGRHA.API.Models.Employee", "Employee")
                        .WithMany("Relatives")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
