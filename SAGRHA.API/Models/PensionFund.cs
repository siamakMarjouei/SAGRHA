using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class PensionFund
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CuaNumber { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}