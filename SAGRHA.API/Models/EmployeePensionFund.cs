namespace SAGRHA.API.Models
{
    public class EmployeePensionFund
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int PensionFundId { get; set; }
        public PensionFund PensionFund { get; set; }

        public string NuaNumber { get; set; }
    }
}