using System;
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

        [Required]
        public string Gender { get; set; }

        [Required]
        public string KnownAs { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.UtcNow;
            LastActive = DateTime.UtcNow;
        }
    }
}