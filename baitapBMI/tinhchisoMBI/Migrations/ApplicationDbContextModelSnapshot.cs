﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tinhchisoMBI.Data;

#nullable disable

namespace tinhchisoMBI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("tinhchisoMBI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("cannang")
                        .HasColumnType("REAL");

                    b.Property<double>("chieucao")
                        .HasColumnType("REAL");

                    b.Property<int>("diemA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("diemB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("diemC")
                        .HasColumnType("INTEGER");

                    b.Property<string>("donhang1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("donhang2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("donhang3")
                        .HasColumnType("TEXT");

                    b.Property<string>("ten")
                        .HasColumnType("TEXT");

                    b.Property<string>("tuoi")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
