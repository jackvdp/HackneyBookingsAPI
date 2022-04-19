using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HackneyBookingAPI.Models.BookingDataContextNS;
using HackneyBookingAPI.Models.BookingNS;
using HackneyBookingAPI.ViewModels.CreateBookingNS;
using HackneyBookingAPI.Models.SlotNS;
using HackneyBookingAPI.Models.PaymentDetailsNS;

namespace HackneyBookingsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly BookingDataContext _context;

        public BookingsController(BookingDataContext context)
        {
            _context = context;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.BookingId)
            {
                return BadRequest();
            }

            _context.Entry(booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(CreateBooking createBooking)
        {
            Booking booking = new Booking()
            {
                FirstName = createBooking.FirstName,
                LastName = createBooking.LastName,
                Email = createBooking.Email,
                SpecialReq = createBooking.SpecialReq,
                BookingReference = Guid.NewGuid().ToString()
            };
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();

        
            
            var slot = await _context.Slots.FindAsync(createBooking.SlotId);

            slot.Available = false;
            slot.BookingId = booking.BookingId;

            _context.Slots.Update(slot);
            await _context.SaveChangesAsync();

            PaymentDetails paymentDetails = new PaymentDetails {
           
                CardholderName = createBooking.CardholderName,
                CardType = createBooking.CardType,
                CardNumber = createBooking.CardNumber,
                BillingAddress = createBooking.BillingAddress,
                ExpiryDate = createBooking.ExpiryDate,
                CVC = createBooking.CVC,
                BookingId = booking.BookingId

            };

            await _context.PaymentDetails.AddAsync(paymentDetails);
            await _context.SaveChangesAsync();
            

            return CreatedAtAction("GetBooking", new { id = booking.BookingId }, booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
