using HackneyBookingAPI.Models.LocationNS;

namespace HackneyBookingAPI.Models.CategoryNS;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Location> Locations { get; set; }
}

