using Microsoft.AspNetCore.Mvc;
using HackneyBookingsAPI.Services;
using HackneyBookingAPI.Models.Booking;
using Microsoft.AspNetCore.Cors;

namespace HackneyBookingAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    public BookingController()
    {
    }

    [HttpGet]
    public ActionResult<List<Booking>> GetAll() {
        Console.WriteLine("Booking***************************");
        return BookingService.GetAll();
    }
        
}