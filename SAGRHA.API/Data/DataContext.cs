using Microsoft.EntityFrameworkCore;
using SAGRHA.API.Models;

namespace SAGRHA.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(){}

        public DbSet<Value> Values { get; set; }
    }
}