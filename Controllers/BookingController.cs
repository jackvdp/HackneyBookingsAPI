using Microsoft.AspNetCore.Mvc;
using HackneyBookingsAPI.Services;
using HackneyBookingAPI.Models.Booking;

namespace HackneyBookingAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    public BookingController()
    {
    }

    [HttpGet]
    public ActionResult<List<Booking>> GetAll() =>
        BookingService.GetAll();
}