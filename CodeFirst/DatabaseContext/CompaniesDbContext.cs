
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.DatabaseContext
{
    public class CompaniesDbContext : DbContext
    {
        public CompaniesDbContext(DbContextOptions<CompaniesDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
