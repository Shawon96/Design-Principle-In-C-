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
            if (emp.EmployeeType == EmployeeType.FullTime.ToString())
            {
                return emp.TotalHoursWorked * 10;
            }
            else if (emp.EmployeeType == EmployeeType.PartTime.ToString())
            {
                return emp.TotalHoursWorked * 5;
            }
            else if (emp.EmployeeType == EmployeeType.Contractor.ToString())
            {
                return emp.TotalHoursWorked * 5;
            }

            return 10;
        }
    }


    public class EmployeeFinanceForFTE : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 10;
        }
    }

    public class EmployeeFinanceForPTE : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 5;
        }
    }

    public class EmployeeFinanceForContractor : EmployeeFinance
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 15;
        }
    }
}