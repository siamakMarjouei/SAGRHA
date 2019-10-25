namespace SAGRHA.API.Models
{
    public class EmployeeInsurance
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int InsuranceCatalogId { get; set; }
        public InsuranceCatalog InsuranceCatalog { get; set; }

        public string Enrollment { get; set; }
    }
}