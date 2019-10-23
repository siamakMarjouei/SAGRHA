using Microsoft.EntityFrameworkCore;
using SAGRHA.API.Models;

namespace SAGRHA.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<RelationTypeCatalog> RelationTypes { get; set; }
        public DbSet<InsuranceCatalog> Insurances { get; set; }
        public DbSet<PensionFund> PensionFunds { get; set; }
      
    }
}