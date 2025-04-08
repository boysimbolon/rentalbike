using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalMotorAPI.Data;
using RentalMotorAPI.Models;

namespace RentalBike.RentalMotorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataBookingController : ControllerBase
    {
        private readonly RentalContext _context;

        public DataBookingController(RentalContext context)
        {
            _context = context;
        }

        // GET: api/DataBooking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataBooking>>> GetBookings()
        {
            var bookings = await _context.DataBookings
                .Include(b => b.Motor)
                .ToListAsync();

            if (bookings == null || bookings.Count == 0)
            {
                return NotFound("Tidak ada data booking yang ditemukan.");
            }

            return Ok(bookings);
        }

        // GET: api/DataBooking/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<DataBooking>> GetBooking(int id)
        {
            var booking = await _context.DataBookings
                .Include(b => b.Motor)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (booking == null)
            {
                return NotFound($"Booking dengan ID {id} tidak ditemukan.");
            }

            return Ok(booking);
        }

        // PUT: api/DataBooking/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooking(int id, [FromBody] DataBooking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest("ID dalam URL tidak sesuai dengan ID booking.");
            }

            var existingBooking = await _context.DataBookings.FindAsync(id);
            if (existingBooking == null)
            {
                return NotFound();
            }

            // Update field yang diizinkan
            existingBooking.NamaPemesan = booking.NamaPemesan;
            existingBooking.EmailPemesan = booking.EmailPemesan;
            existingBooking.NoHpPemesan = booking.NoHpPemesan;
            existingBooking.MotorId = booking.MotorId;
            existingBooking.RentalDate = booking.RentalDate;
            existingBooking.LamaJam = booking.LamaJam;
            existingBooking.RentalStatus = booking.RentalStatus;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Terjadi kesalahan saat menyimpan data.");
            }

            return NoContent();
        }

        // DELETE: api/DataBooking/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _context.DataBookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound($"Booking dengan ID {id} tidak ditemukan.");
            }

            _context.DataBookings.Remove(booking);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // POST: api/DataBooking
        [HttpPost]
        public async Task<ActionResult<DataBooking>> CreateBooking([FromBody] DataBooking booking)
        {
            if (booking == null)
            {
                return BadRequest("Data booking tidak valid.");
            }

            // Validasi dasar bisa ditambahkan di sini jika diperlukan
            if (string.IsNullOrEmpty(booking.NamaPemesan) ||
                string.IsNullOrEmpty(booking.EmailPemesan) ||
                string.IsNullOrEmpty(booking.NoHpPemesan) ||
                booking.MotorId == 0 ||
                booking.RentalDate == default ||
                booking.LamaJam <= 0)
            {
                return BadRequest("Beberapa field booking wajib diisi.");
            }

            try
            {
                _context.DataBookings.Add(booking);
                await _context.SaveChangesAsync();

                // Mengembalikan lokasi resource yang baru dibuat
                return CreatedAtAction(nameof(GetBooking), new { id = booking.Id }, booking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Terjadi kesalahan saat menyimpan data: {ex.Message}");
            }
        }

        // Helper method untuk mengecek apakah booking ada
        private bool BookingExists(int id)
        {
            return _context.DataBookings.Any(e => e.Id == id);
        }
    }
}