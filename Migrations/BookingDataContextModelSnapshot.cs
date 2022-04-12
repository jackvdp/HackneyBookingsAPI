﻿// <auto-generated />
using System;
using HackneyBookingAPI.Models.BookingDataContextNS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HackneyBookingsAPI.Migrations
{
    [DbContext(typeof(BookingDataContext))]
    partial class BookingDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("HackneyBookingAPI.Models.BookingNS.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("BookingId"));

                    b.Property<string>("BookingReference")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("SlotId")
                        .HasColumnType("integer");

                    b.Property<string>("SpecialReq")
                        .HasColumnType("text");

                    b.HasKey("BookingId");

                    b.HasIndex("SlotId")
                        .IsUnique();

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.CategoryNS.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.LocationNS.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.PaymentDetailsNS.PaymentDetails", b =>
                {
                    b.Property<int>("PaymentDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("PaymentDetailsId"));

                    b.Property<string>("BillingAddress")
                        .HasColumnType("text");

                    b.Property<int?>("BookingId")
                        .HasColumnType("integer");

                    b.Property<int>("CVC")
                        .HasColumnType("integer");

                    b.Property<int>("CardNumber")
                        .HasColumnType("integer");

                    b.Property<string>("CardType")
                        .HasColumnType("text");

                    b.Property<string>("CardholderName")
                        .HasColumnType("text");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("text");

                    b.HasKey("PaymentDetailsId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.SlotNS.Slot", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("SlotId"));

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<int?>("BookingId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("SlotId");

                    b.HasIndex("LocationId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.BookingNS.Booking", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.SlotNS.Slot", "Slot")
                        .WithOne("Booking")
                        .HasForeignKey("HackneyBookingAPI.Models.BookingNS.Booking", "SlotId");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.LocationNS.Location", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.CategoryNS.Category", "Category")
                        .WithMany("Locations")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.PaymentDetailsNS.PaymentDetails", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.BookingNS.Booking", "Booking")
                        .WithOne("PaymentDetails")
                        .HasForeignKey("HackneyBookingAPI.Models.PaymentDetailsNS.PaymentDetails", "BookingId");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.SlotNS.Slot", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.LocationNS.Location", "Location")
                        .WithMany("Slots")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.BookingNS.Booking", b =>
                {
                    b.Navigation("PaymentDetails");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.CategoryNS.Category", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.LocationNS.Location", b =>
                {
                    b.Navigation("Slots");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.SlotNS.Slot", b =>
                {
                    b.Navigation("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
