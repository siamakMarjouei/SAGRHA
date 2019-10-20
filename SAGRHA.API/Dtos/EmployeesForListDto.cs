using System;
using System.Collections.Generic;
using SAGRHA.API.Models;

namespace SAGRHA.API.Dtos
{
    public class EmployeesForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Age { get; set; }
        public string DNI { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string AFP { get; set; }
        public string Address { get; set; }
        public string Profession { get; set; }
        public ICollection<RelativeToReturnDto> Relatives { get; set; }
    }
}