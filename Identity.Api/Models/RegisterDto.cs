using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Models
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        public string Forename { get; set; }

        [Required]
        [StringLength(250)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
