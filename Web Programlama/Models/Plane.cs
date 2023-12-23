using System.ComponentModel.DataAnnotations;

namespace Web_Programlama.Models
{
    public class Plane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;


    }
}
