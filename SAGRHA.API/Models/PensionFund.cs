using System.Collections.Generic;

namespace SAGRHA.API.Models
{
    public class PensionFund
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeePensionFund> EmployeePensionFunds { get; set; }

    }
}