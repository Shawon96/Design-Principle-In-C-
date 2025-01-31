using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{

    public class EmployeeReWards
    {
        public virtual double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }
    public class EmployeeFinance : EmployeeReWards
    {
        public virtual double CalculatePay(Employee emp)
        {

            return 10;
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

    public class EmployeeFinanceForContractor : EmployeeReWards
    {
        public override double CalculateRewards(Employee emp)
        {
            return 300;
        }
    }
}