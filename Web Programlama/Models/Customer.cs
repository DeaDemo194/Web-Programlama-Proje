using System.ComponentModel.DataAnnotations;


namespace Web_Programlama.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public string Gender { get; set; } = null!;

        

    }
}
