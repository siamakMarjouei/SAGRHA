using Microsoft.EntityFrameworkCore;
using SAGRHA.API.Models;

namespace SAGRHA.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeePensionFund>().HasKey(sc => new { sc.EmployeeId, sc.PensionFundId });
            modelBuilder.Entity<EmployeeInsurance>().HasKey(sc => new { sc.EmployeeId, sc.InsuranceCatalogId });
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<RelationTypeCatalog> RelationTypes { get; set; }
        public DbSet<InsuranceCatalog> Insurances { get; set; }
        public DbSet<PensionFund> PensionFunds { get; set; }
        public DbSet<EmployeeInsurance> InsuranceContracts { get; set; }
        public DbSet<EmployeePensionFund> Affiliations { get; set; }

    }
}