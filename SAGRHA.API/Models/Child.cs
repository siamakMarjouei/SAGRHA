using System;

namespace SAGRHA.API.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}