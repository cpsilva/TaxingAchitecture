using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee
{
    public interface IEmployeeBll
    {
        EmployeeViewModel CalculateTax(EmployeeViewModel employee);
    }
}