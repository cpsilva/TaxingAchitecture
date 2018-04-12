using Microsoft.AspNetCore.Mvc;
using Tax.BusinessLogic.Employee;
using Tax.ViewModels;

namespace Tax.ApplicationService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBll _employeeBll;

        public EmployeeController(IEmployeeBll employeeBll)
        {
            _employeeBll = employeeBll;
        }

        // GET
        public EmployeeViewModel Get(EmployeeViewModel employee)
        {
            return _employeeBll.CalculateTax(employee);
        }
    }
}