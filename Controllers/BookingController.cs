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

    [EnableCors]
    [HttpGet]
    public ActionResult<List<Booking>> GetAll() =>
        BookingService.GetAll();
}