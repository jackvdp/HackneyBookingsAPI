using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using HackneyBookingAPI.Models.Location;

namespace HackneyBookingAPI.Models.BookingNS;
 public class Booking
 {
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public LocationPlace? LocationName { get; set; }

    public DateTime? Date { get; set; }

    public bool PaymentReceived { get; set; }

 }
