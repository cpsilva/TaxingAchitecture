using System;
using System.Collections.Generic;
using System.Text;
using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee.CalcTaxStrategy
{
    public class CalcTaxFourthStrategy : ICalcTaxStrategy
    {
        private const decimal minRange = 7000;
        private const decimal imposto = 25;

        public EmployeeViewModel Calculate(decimal salario)
        {
            if (!IsSatisfied(salario)) { return null; }

            return new EmployeeViewModel
            {
                SalarioBruto = salario,
                Imposto = imposto,
                SalarioLiquido = salario - (salario / 100 * imposto)
            };
        }

        public bool IsSatisfied(decimal salario)
        {
            return salario > minRange;
        }
    }
}
