using Microsoft.EntityFrameworkCore;
using HackneyBookingAPI.Models.BookingNS;
using HackneyBookingAPI.Models.LocationNS;
using HackneyBookingAPI.Models.CategoryNS;
using HackneyBookingAPI.Models.PaymentDetailsNS;
using HackneyBookingAPI.Models.SlotNS;

namespace HackneyBookingAPI.Models.BookingDataContextNS;

public class BookingDataContext: DbContext {

    public BookingDataContext(DbContextOptions<BookingDataContext> options): base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder) {
        modelbuilder.UseSerialColumns();
    }

    public DbSet<Booking> Bookings { get; set;}
    public DbSet<Category> Categories { get; set;}
    public DbSet<Location> Locations { get; set;}
    public DbSet<PaymentDetails> PaymentDetails { get; set;}
    public DbSet<Slot> Slots { get; set;}
}