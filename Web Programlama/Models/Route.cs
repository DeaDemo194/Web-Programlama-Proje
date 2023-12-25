using MessagePack.Formatters;
using System.ComponentModel.DataAnnotations;

namespace Web_Programlama.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        public string To { get; set; } = null!;
        public string From { get; set; } = null!;

        public string RouteName => $"{From} {To}";

    }
}
