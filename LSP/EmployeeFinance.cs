using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{
    public class EmployeeFinance
    {
        public virtual double CalculatePay(Employee emp)
        {

            return 10;
        }

        public virtual double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }


    public class EmployeeFinanceForFTE : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 10;
        }

        public override double CalculateRewards(Employee emp)
        {
            return 200;
        }
    }

    public class EmployeeFinanceForPTE : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 5;
        }

        public override double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }

    public class EmployeeFinanceForContractor : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            throw new NotImplementedException();
        }

        public override double CalculateRewards(Employee emp)
        {
            return 300;
        }
    }
}