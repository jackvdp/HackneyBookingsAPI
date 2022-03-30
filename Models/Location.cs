
namespace HackneyBookingAPI.Models.Location;

 public class LocationPlace
 {

    public LocationPlace(int Id, string? Name)
    {
        this.Id = Id;
        this.Name = Name;
    }

    public int Id { get; set; }

    public string? Name { get; set; }

 }

 