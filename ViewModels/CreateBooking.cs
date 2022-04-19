using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using HackneyBookingAPI.Models.PaymentDetailsNS;
using HackneyBookingAPI.Models.BookingNS;


namespace HackneyBookingAPI.ViewModels.CreateBookingNS;

public class CreateBooking
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string SpecialReq { get; set; }

    // public string BookingReference { get; set; }

    public int SlotId { get; set; }

    public string CardholderName { get; set; }

    public string CardType { get; set; }

    public int CardNumber { get; set; }

    public string BillingAddress { get; set; }

    public int CVC { get; set; }

    public string ExpiryDate { get; set; }
}


 