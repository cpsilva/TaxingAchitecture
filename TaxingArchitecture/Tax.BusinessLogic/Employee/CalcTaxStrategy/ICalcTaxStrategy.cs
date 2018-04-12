using System;
using System.Collections.Generic;
using System.Text;
using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee.CalcTaxStrategy
{
    public interface ICalcTaxStrategy
    {
        EmployeeViewModel Calculate(decimal salario);

        bool IsSatisfied(decimal salario);
    }
}
