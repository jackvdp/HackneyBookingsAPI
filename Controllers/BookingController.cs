using Microsoft.AspNetCore.Mvc;
using HackneyBookingAPI.Models.BookingNS;
using HackneyBookingAPI.Models.BookingDataContextNS;

namespace HackneyBookingAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{

    private BookingDataContext context;
    public BookingController(BookingDataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult<List<Booking>> GetAll() {
        context.Database.EnsureCreated();
        return context.Bookings.ToList();
    }

    [HttpPost]
    public ActionResult<List<Booking>> AddBooking(Booking booking) {
        context.Database.EnsureCreated();
        context.Bookings.Add(booking);
        context.SaveChanges();
        return context.Bookings.ToList();
    }
        
}