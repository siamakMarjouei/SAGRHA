using System;

namespace SAGRHA.API.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public int Cell { get; set; }
        public string Relationship { get; set; }
        public bool IsEmergency { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}