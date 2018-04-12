using System;
using System.Collections.Generic;
using System.Text;
using Tax.ViewModels;

namespace Tax.BusinessLogic.Employee.CalcTaxStrategy
{
    public class CalcTaxFirstStrategy : ICalcTaxStrategy
    {
        private const decimal maxRange = 3000;
        private const decimal imposto = 0;

        public EmployeeViewModel Calculate(decimal salario)
        {
            if (!IsSatisfied(salario)) { return null; }

            return new EmployeeViewModel
            {
                SalarioBruto = salario,
                Imposto = imposto,
                SalarioLiquido = salario
            };
        }

        public bool IsSatisfied(decimal salario)
        {
            return salario < maxRange;
        }
    }
}
