using HackneyBookingAPI.Models.PaymentDetailsNS;
using HackneyBookingAPI.Models.SlotNS;
using System.ComponentModel.DataAnnotations.Schema;

namespace HackneyBookingAPI.Models.BookingNS;
public class Booking
{
    public int BookingId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string SpecialReq { get; set; }

    public string BookingReference { get; set; }


    public virtual Slot Slot { get; set; }

    public virtual PaymentDetails PaymentDetails { get; set; }
}