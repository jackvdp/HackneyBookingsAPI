using HackneyBookingAPI.Models.BookingNS;
using HackneyBookingAPI.Models.LocationNS;

using System.ComponentModel.DataAnnotations.Schema;

namespace HackneyBookingAPI.Models.SlotNS;

public class Slot
{
    public int SlotId { get; set; }

    public bool Available { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public decimal PricePerHour { get; set; }

    public Nullable<int> LocationId { get; set; }

    public virtual Location Location { get; set; }

    
    public int? BookingId { get; set; }
    
    [ForeignKey("BookingId")]
    public virtual Booking Booking { get; set; }

}


