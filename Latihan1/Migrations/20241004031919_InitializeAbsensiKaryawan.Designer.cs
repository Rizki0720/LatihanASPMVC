﻿// <auto-generated />
using System;
using Latihan1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Latihan1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241004031919_InitializeAbsensiKaryawan")]
    partial class InitializeAbsensiKaryawan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Latihan1.Models.AbsensiKaryawan", b =>
                {
                    b.Property<Guid>("AbsensiKaryawanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("JamKeluar")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("JamMasuk")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("KodeKaryawan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaKaryawan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("TglKeluar")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("TglMasuk")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("AbsensiKaryawanId");

                    b.ToTable("MstAbsensiKaryawan", "dbo");
                });

            modelBuilder.Entity("Latihan1.Models.Karyawan", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("MstKaryawan", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
