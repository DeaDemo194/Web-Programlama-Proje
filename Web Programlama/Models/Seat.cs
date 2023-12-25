using System.ComponentModel.DataAnnotations;

namespace Web_Programlama.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public Plane Plane { get; set; } = null!;
        public bool IsEmpty { get; set; }
    }
}
