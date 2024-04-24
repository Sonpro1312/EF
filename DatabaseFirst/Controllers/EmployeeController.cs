using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [Route("/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly CompaniesContext _companiesContext;
        public EmployeeController(CompaniesContext companiesContext) : base()
        {
            _companiesContext = companiesContext;
        }

        public IEnumerable<Employee> Test()
        {
            return _companiesContext.Employees.Where(e => e.Age >= 30 && e.Age <= 40 && e.Department.Name == "Marketing");
        }
    }
}
