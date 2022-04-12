using HackneyBookingAPI.Models.BookingNS;

namespace HackneyBookingAPI.Models.PaymentDetailsNS;

public class PaymentDetails
{
    public int PaymentDetailsId { get; set; }

    public string CardholderName { get; set; }

    public string CardType { get; set; }

    public int CardNumber { get; set; }

    public string BillingAddress { get; set; }

    public int CVC { get; set; }

    public string ExpiryDate { get; set; }

    public Nullable<int> BookingId { get; set; }
    public virtual Booking Booking { get; set; }

}








