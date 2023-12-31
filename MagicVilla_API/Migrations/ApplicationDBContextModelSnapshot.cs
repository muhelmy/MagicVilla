﻿// <auto-generated />
using System;
using MagicVilla_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_API.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Balcony, Parking",
                            CreatedDate = new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1732),
                            Details = "",
                            ImageUrl = "https://t4.ftcdn.net/jpg/03/70/64/43/360_F_370644357_MDF4UXLAXTyyi2OyuK66tWW9cA2f8svL.jpg",
                            Name = "Cozy Apartment",
                            Occupancy = 2,
                            Rate = 1200.5,
                            Sqft = 800,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Gym, Pool",
                            CreatedDate = new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1784),
                            Details = "",
                            ImageUrl = "https://im.proptiger.com/1/3232159/6/scape-villas-elevation-146125154.jpeg",
                            Name = "Modern Loft",
                            Occupancy = 4,
                            Rate = 2000.75,
                            Sqft = 1200,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Garden, Fireplace",
                            CreatedDate = new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1787),
                            Details = "",
                            ImageUrl = "https://sky119191.b-cdn.net/wp-content/uploads/2023/02/word-image-50349-1-1.jpeg",
                            Name = "Charming House",
                            Occupancy = 6,
                            Rate = 2500.25,
                            Sqft = 1500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Beach Access, Ocean View",
                            CreatedDate = new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1790),
                            Details = "",
                            ImageUrl = "https://amazingarchitecture.com/storage/711/Deep-Villa-Atrey-and-Associates-New-Delhi-ndia-Amazing-Architecture-House.jpg",
                            Name = "Seaside Villa",
                            Occupancy = 8,
                            Rate = 3500.0,
                            Sqft = 2000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "City View, Concierge",
                            CreatedDate = new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1793),
                            Details = "",
                            ImageUrl = "https://speed.damacproperties.com/sites/default/files/2021-05/premier-villas-hero-banner-mobile.jpg",
                            Name = "Downtown Penthouse",
                            Occupancy = 4,
                            Rate = 2800.5,
                            Sqft = 1800,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
