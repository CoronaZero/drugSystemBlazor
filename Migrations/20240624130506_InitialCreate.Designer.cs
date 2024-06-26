﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using drugSystemBlazor;

#nullable disable

namespace drugSystemBlazor.Migrations
{
    [DbContext(typeof(DSDBcontext))]
    [Migration("20240624130506_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("drugSystemBlazor.Drug", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .HasDatabaseName("DrugName");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("drugSystemBlazor.Prescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPatientTakes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PatientName")
                        .HasDatabaseName("PatientNameIndex");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("drugSystemBlazor.PrescriptionDrugs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DrugID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrescriptionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DrugID");

                    b.HasIndex("PrescriptionID");

                    b.ToTable("PrescriptionDrugs");
                });

            modelBuilder.Entity("drugSystemBlazor.PrescriptionDrugs", b =>
                {
                    b.HasOne("drugSystemBlazor.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("drugSystemBlazor.Prescription", null)
                        .WithMany("Drugs")
                        .HasForeignKey("PrescriptionID");

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("drugSystemBlazor.Prescription", b =>
                {
                    b.Navigation("Drugs");
                });
#pragma warning restore 612, 618
        }
    }
}
