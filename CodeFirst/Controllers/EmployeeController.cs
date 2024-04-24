using CodeFirst.DatabaseContext;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [Route("/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly CompaniesDbContext _companiesDbContext;
        public EmployeeController(CompaniesDbContext companiesDbContext) : base()
        {
            _companiesDbContext = companiesDbContext;
        }

        public IEnumerable<Employee> Test()
        {
            return _companiesDbContext.Employee.Where(e => e.Age >= 30 && e.Age <= 40 && e.Department.Name == "Marketing");
        }
    }
}
