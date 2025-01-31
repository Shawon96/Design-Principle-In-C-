using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{
    public class EmployeeFinance
    {
        public double CalculatePay(Employee emp)
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
}