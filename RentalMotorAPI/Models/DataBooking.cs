using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalMotorAPI.Models
{
    [Table("data_booking")]
    public class DataBooking
    {
        public int Id { get; set; }
        public string NamaPemesan { get; set; }
        public string EmailPemesan { get; set; }
        public string NoHpPemesan { get; set; }
        public int MotorId { get; set; }
        public Motor Motor { get; set; }

        public DateTime RentalDate { get; set; }
        public int LamaJam { get; set; }
        public string RentalStatus { get; set; }
    }
}
