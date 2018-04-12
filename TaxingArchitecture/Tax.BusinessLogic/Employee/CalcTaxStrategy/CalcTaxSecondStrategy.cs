using System;
using System.Collections.Generic;
using System.Text;
using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee.CalcTaxStrategy
{
    public class CalcTaxThirdStrategy : ICalcTaxStrategy
    {
        private const decimal maxRange = 5000;
        private const decimal minRange = 3000;
        private const decimal imposto = 10;

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
            return salario >= minRange && salario < maxRange;
        }
    }
}
