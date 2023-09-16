﻿// <auto-generated />
using System;
using Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Migrations
{
    [DbContext(typeof(HealthCareDbContext))]
    [Migration("20230916100002_InitialCommit")]
    partial class InitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("DATETIME");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INT");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Physicians", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<string>("DoctorFirstName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("DoctorLastName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("INT");

                    b.HasKey("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Specializations", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<sbyte>("Status")
                        .HasColumnType("TINYINT");

                    b.Property<string>("Type")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Patients", b =>
                {
                    b.HasOne("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Physicians", "Physician")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physician");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Physicians", b =>
                {
                    b.HasOne("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Specializations", "Specialization")
                        .WithMany("Physicians")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Physicians", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities.Specializations", b =>
                {
                    b.Navigation("Physicians");
                });
#pragma warning restore 612, 618
        }
    }
}
