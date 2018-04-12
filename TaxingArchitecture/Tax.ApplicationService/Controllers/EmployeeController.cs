using Microsoft.AspNetCore.Mvc;
using Tax.ViewModels;

namespace Tax.ApplicationService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        // GET
        public EmployeeViewModel Get(EmployeeViewModel employee)
        {
            return new EmployeeViewModel { Nome = "teste" };
        }
    }
}