using Microsoft.EntityFrameworkCore;
using HackneyBookingAPI.Models.BookingNS;
using HackneyBookingAPI.Models.Location;

namespace HackneyBookingAPI.Models.BookingDataContextNS;

public class BookingDataContext: DbContext {

    public BookingDataContext(DbContextOptions<BookingDataContext> options): base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder) {
        modelbuilder.UseSerialColumns();
    }

    public DbSet<Booking> Bookings { get; set;}
    public DbSet<LocationPlace> Locations { get; set;}
}