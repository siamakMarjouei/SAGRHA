using System;
using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int? InsuranceId { get; set; }
        public int? PensionFundId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DNI { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Profession { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PensionFund PensionFund { get; set; }
        public InsuranceCatalog Insurance { get; set; }
        public ICollection<Relative> Relatives { get; set; }

    }
}