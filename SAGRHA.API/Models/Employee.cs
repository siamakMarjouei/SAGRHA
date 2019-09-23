using System;
using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DNI { get; set; }
        public int Phone { get; set; }
        public int Cell { get; set; }
        public string Email { get; set; }
        public string AFP { get; set; }
        public int CUA { get; set; }
        public string Address { get; set; }
        public string Profession { get; set; }
        public ICollection<Child> Children { get; set; }


    }
}