using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class InsuranceCatalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}