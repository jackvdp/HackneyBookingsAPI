using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

using HackneyBookingAPI.Models.CategoryNS;


namespace HackneyBookingAPI.ViewModels.CreateSlotNS;

public class CreateSlot
{
    [Required]
    public bool Available { get; set; }

    [Required]
    public string StartTime { get; set; }

    [Required]
    public string EndTime { get; set; }
    
    [Required]
    public int PricePerHour { get; set; }

    [Required]
    public int LocationId { get; set; }

    


}


 
