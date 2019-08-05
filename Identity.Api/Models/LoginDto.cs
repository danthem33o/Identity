using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Models
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
