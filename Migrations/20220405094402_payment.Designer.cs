﻿// <auto-generated />
using System;
using HackneyBookingAPI.Models.BookingDataContextNS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HackneyBookingsAPI.Migrations
{
    [DbContext(typeof(BookingDataContext))]
    [Migration("20220405094402_payment")]
    partial class payment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<string>("SpecialReq")
                        .HasColumnType("text");

                    b.HasKey("BookingId");

                    b.HasIndex("LocationId");

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
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Locations");
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

                    b.Property<string>("Field")
                        .HasColumnType("text");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("SlotId");

                    b.HasIndex("BookingId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.BookingNS.Booking", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.LocationNS.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("HackneyBookingAPI.Models.PaymentDetailsNS.PaymentDetails", "PaymentDetails", b1 =>
                        {
                            b1.Property<int>("BookingId")
                                .HasColumnType("integer");

                            b1.Property<string>("BillingAddress")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int>("CVC")
                                .HasColumnType("integer");

                            b1.Property<int>("CardNumber")
                                .HasColumnType("integer");

                            b1.Property<string>("CardType")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("CardholderName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("ExpiryDate")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int>("PaymentDetailsId")
                                .HasColumnType("integer");

                            b1.HasKey("BookingId");

                            b1.ToTable("PaymentDetails");

                            b1.WithOwner("Booking")
                                .HasForeignKey("BookingId");

                            b1.Navigation("Booking");
                        });

                    b.Navigation("Location");

                    b.Navigation("PaymentDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.LocationNS.Location", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.CategoryNS.Category", "Category")
                        .WithMany("Locations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.SlotNS.Slot", b =>
                {
                    b.HasOne("HackneyBookingAPI.Models.BookingNS.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HackneyBookingAPI.Models.CategoryNS.Category", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
