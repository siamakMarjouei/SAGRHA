using System;
using System.ComponentModel.DataAnnotations;

namespace SAGRHA.API.Dtos
{
    public class EmployeeForRegisterDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string PlaceOfBirth { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        public string Address { get; set; }
        
        [Required]
        public string Profession { get; set; }
    }
}