﻿// <auto-generated />
using System;
using GivskudApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GivskudApi.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20181201140045_DecimalCoordinatesPrecisionAndRequiredAttributes")]
    partial class DecimalCoordinatesPrecisionAndRequiredAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GivskudApi.Models.Description", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime?>("FeedingTime");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("GivskudApi.Models.Marker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DescriptionID");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18, 8)");

                    b.Property<decimal>("Lng")
                        .HasColumnType("decimal(18, 8)");

                    b.Property<int>("MarkerTypeID");

                    b.HasKey("ID");

                    b.HasIndex("DescriptionID");

                    b.ToTable("Markers");
                });

            modelBuilder.Entity("GivskudApi.Models.MarkerType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("MarkerTypes");
                });

            modelBuilder.Entity("GivskudApi.Models.Marker", b =>
                {
                    b.HasOne("GivskudApi.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
