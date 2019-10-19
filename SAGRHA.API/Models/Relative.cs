using System;

namespace SAGRHA.API.Models
{
    public class Relative
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Dni { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public RelationTypeCatalog RelationTypeCatalog { get; set; }
        public int RelationTypeCatalogId { get; set; }
   
    }
}