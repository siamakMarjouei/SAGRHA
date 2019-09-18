using System.ComponentModel.DataAnnotations;

namespace SAGRHA.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 6, 
        ErrorMessage = "Password must be between 6 and 8 characters")]
        public string Password { get; set; }
    }
}