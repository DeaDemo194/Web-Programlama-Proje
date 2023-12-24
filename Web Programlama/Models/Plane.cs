using System.ComponentModel.DataAnnotations;

namespace Web_Programlama.Models
{
    public class Plane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Company { get; set; } = null!;

        public int SeatCount { get; set; }
        public Seat[] Seats { get; set; } = null!;

    }
}
