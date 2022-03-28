using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 public class Booking
 {
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Location { get; set; }

    public DateTime? Date { get; set; }

    public bool PaymentReceived { get; set; }

 }
