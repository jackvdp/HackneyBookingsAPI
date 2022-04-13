using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HackneyBookingAPI.Models.BookingDataContextNS;
using HackneyBookingAPI.Models.SlotNS;
using HackneyBookingAPI.ViewModels.CreateSlotNS;

namespace HackneyBookingsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SlotsController : ControllerBase
    {
        private readonly BookingDataContext _context;

        public SlotsController(BookingDataContext context)
        {
            _context = context;
        }

        // GET: /Slots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlots(int id)
        {
            return await _context.Slots.Where(x => x.LocationId == id).ToListAsync();
        }

        // GET: /Slots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slot>> GetSlot(int id)
        {
            var slot = await _context.Slots.FindAsync(id);

            if (slot == null)
            {
                return NotFound();
            }

            return slot;
        }

        // PUT: /Slots/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlot(int id, Slot slot)
        {
            if (id != slot.SlotId)
            {
                return BadRequest();
            }

            _context.Entry(slot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotExists(id))
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

        // POST: /Slots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Slot>> PostSlot(CreateSlot createSlot)
        {
            string dateInputStartTime = createSlot.StartTime;
            var parsedDateStartTime = DateTime.Parse(dateInputStartTime);
            string dateInputEndTime = createSlot.EndTime;
            var parsedDateEndTime = DateTime.Parse(dateInputEndTime);
            
            Slot slot = new Slot{
                Available = createSlot.Available,
                StartTime = parsedDateStartTime,
                EndTime = parsedDateEndTime,
                PricePerHour = createSlot.PricePerHour,
                LocationId = createSlot.LocationId
            };
            _context.Slots.Add(slot);
            await _context.SaveChangesAsync();

            return Ok(slot);
        }

        // DELETE: /Slots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlot(int id)
        {
            var slot = await _context.Slots.FindAsync(id);
            if (slot == null)
            {
                return NotFound();
            }

            _context.Slots.Remove(slot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SlotExists(int id)
        {
            return _context.Slots.Any(e => e.SlotId == id);
        }
    }
}
