using System.ComponentModel.DataAnnotations.Schema;

namespace RentalMotorAPI.Models;

[Table("motor")]
public class Motor

{

    public int Id { get; set; }

    public string NamaMotor { get; set; } = string.Empty;

    public string PlatMotor { get; set; } = string.Empty;

    public decimal HargaSewa { get; set; }

    public string? GambarMotor { get; set; }


    public ICollection<DataBooking> DataBookings { get; set; } = new List<DataBooking>();

}

