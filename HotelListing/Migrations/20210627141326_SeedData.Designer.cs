﻿// <auto-generated />
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210627141326_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "United States",
                            ShortName = "US"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Iran",
                            ShortName = "IR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Turkey",
                            ShortName = "TU"
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "some address1",
                            CountryId = 1,
                            Name = "hotel1",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "some address2",
                            CountryId = 1,
                            Name = "hotel1",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "some address3",
                            CountryId = 1,
                            Name = "hotel2",
                            Rating = 3.2000000000000002
                        },
                        new
                        {
                            Id = 4,
                            Address = "some address4",
                            CountryId = 2,
                            Name = "hotel3",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 5,
                            Address = "some address5",
                            CountryId = 2,
                            Name = "hotel4",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 6,
                            Address = "some address6",
                            CountryId = 3,
                            Name = "hotel5",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.Data.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}