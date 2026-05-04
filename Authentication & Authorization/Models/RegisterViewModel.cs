using System.ComponentModel.DataAnnotations;

namespace Authentication___Authorization.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain an uppercase letter, a lowercase letter, and a number.")]
        public string Password { get; set; }


    }
}
