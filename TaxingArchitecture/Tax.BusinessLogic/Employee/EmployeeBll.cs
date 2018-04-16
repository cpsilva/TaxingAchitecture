using System.Collections.Generic;
using Tax.BusinessLogic.Employee.CalcTaxStrategy;
using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee
{
    public class EmployeeBll : IEmployeeBll
    {
        public EmployeeViewModel CalculateTax(EmployeeViewModel employee)
        {
            var funcionario = employee;
            var strategies = new List<ICalcTaxStrategy>
            {
                new CalcTaxFirstStrategy(),
                new CalcTaxSecondStrategy(),
                new CalcTaxThirdStrategy(),
                new CalcTaxFourthStrategy()
            };

            foreach (var strategy in strategies)
            {
                if (strategy.IsSatisfied(employee.SalarioBruto))
                {
                    employee = strategy.Calculate(employee.SalarioBruto);
                    employee.Nome = funcionario.Nome;
                    employee.Email = funcionario.Email;
                    break;
                }
            }

            return employee;
        }
    }
}