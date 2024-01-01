using System.ComponentModel.DataAnnotations;

namespace Web_Programlama.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public int SeatNumber { get; set; }

        public bool IsEmpty { get; set; } = true;

        public Seat(int SeatNumber) { 
            this.SeatNumber = SeatNumber;
            this.IsEmpty = true;
        }
    }
}
