using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalMotorAPI.Data;
using RentalMotorAPI.Models;

namespace RentalBike.RentalMotorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MotorController : ControllerBase
{
    private readonly RentalContext _context;

    public MotorController(RentalContext context)
    {
        _context = context;
    }

    // GET: api/Motor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Motor>>> GetMotors()
    {
        var motors = await _context.Motors.ToListAsync();

        if (motors == null || motors.Count == 0)
        {
            return NotFound("Tidak ada data motor yang ditemukan.");
        }

        return Ok(motors);
    }

    // GET: api/Motor/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Motor>> GetMotor(int id)
    {
        var motor = await _context.Motors.FindAsync(id);

        if (motor == null)
        {
            return NotFound($"Motor dengan ID {id} tidak ditemukan.");
        }

        return Ok(motor);
    }

    // POST: api/Motor
    [HttpPost]
    public async Task<ActionResult<Motor>> CreateMotor([FromBody] Motor motor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<global::RentalMotorAPI.Models.Motor> entityEntry = _context.Motors.Add(motor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetMotor), new { id = motor.Id }, motor);
    }

    // PUT: api/Motor/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMotor(int id, [FromBody] Motor motor)
    {
        if (id != motor.Id)
        {
            return BadRequest("ID dalam URL tidak sesuai dengan ID motor.");
        }

        var existingMotor = await _context.Motors.FindAsync(id);
        if (existingMotor == null)
        {
            return NotFound($"Motor dengan ID {id} tidak ditemukan.");
        }

        // Update field yang diperbolehkan
        existingMotor.NamaMotor = motor.NamaMotor;

        existingMotor.PlatMotor = motor.PlatMotor;
        existingMotor.HargaSewa = motor.HargaSewa;
        existingMotor.GambarMotor = motor.GambarMotor;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            return StatusCode(500, "Terjadi kesalahan saat menyimpan perubahan.");
        }

        return NoContent();
    }

    // DELETE: api/Motor/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMotor(int id)
    {
        var motor = await _context.Motors.FindAsync(id);

        if (motor == null)
        {
            return NotFound($"Motor dengan ID {id} tidak ditemukan.");
        }

        _context.Motors.Remove(motor);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MotorExists(int id)
    {
        return _context.Motors.Any(e => e.Id == id);
    }
}
