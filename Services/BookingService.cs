using HackneyBookingAPI.Models.Booking;

namespace HackneyBookingsAPI.Services;

public static class BookingService
{
    static List<Booking> Bookings { get; }
    static int nextId = 3;
    static BookingService()
    {
        Bookings = new List<Booking>
        {
            new Booking { 
                Id = 1, 
                FirstName = "Jane", 
                LastName = "Doe" , 
                Email = "jane.doe@madetech.com", 
                Location = "Hackney Marshes", 
                Date = new DateTime(2022, 3, 30, 8, 30, 0), 
                PaymentReceived = true  
            },
            
            new Booking { 
                Id = 2, 
                FirstName = "Joe", 
                LastName = "Doe" , 
                Email = "joe.doe@madetech.com", 
                Location = "Hackney Marshes", 
                Date = new DateTime(2022, 3, 30, 10, 30, 0),  
                PaymentReceived = true  
            },
        };
    }

    public static List<Booking> GetAll() => Bookings;

    public static Booking? Get(int id) => Bookings.FirstOrDefault(p => p.Id == id);

    public static void Add(Booking booking)
    {
        booking.Id = nextId++;
        Bookings.Add(booking);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Bookings.Remove(pizza);
    }

    public static void Update(Booking booking)
    {
        var index = Bookings.FindIndex(p => p.Id == booking.Id);
        if(index == -1)
            return;

        Bookings[index] = booking;
    }
}