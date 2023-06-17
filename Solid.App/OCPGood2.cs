using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPGood2
{
    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }
    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }
    }
}
