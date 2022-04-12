using HackneyBookingAPI.Models.CategoryNS;

using HackneyBookingAPI.Models.SlotNS;

namespace HackneyBookingAPI.Models.LocationNS;

public class Location
{
    public int LocationId { get; set; }

    public string Address { get; set; }

    public string Name { get; set; }

    public Nullable<int> CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<Slot> Slots { get; set; }

}


