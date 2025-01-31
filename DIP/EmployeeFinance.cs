using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{
    public interface IEmployeeRewards
    {
        double CalculateRewards(Employee emp);
    }

    public interface IEmployeeFinance : IEmployeeRewards
    {
        double CalculatePay(Employee emp);
    }

    public interface IStockOptions : IEmployeeFinance
    {
        double CalculateStockOptions(Employee emp);
    }

    public class EmployeeReWards : IEmployeeRewards
    {
        public virtual double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }
    public class EmployeeFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee emp)
        {
            return 10;
        }
        public double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }
    public class EmployeeFinanceForFTE : IEmployeeFinance
    {
        public double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 10;
        }
        public double CalculateRewards(Employee emp)
        {
            return 200;
        }
    }

    public class EmployeeFinanceForPTE : IEmployeeFinance
    {
        public double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 5;
        }

        public double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }

    public class EmployeeFinanceForContractor : IEmployeeRewards
    {
        public double CalculateRewards(Employee emp)
        {
            return 300;
        }
    }

    public class EmployeeFinanceForCLevel : IStockOptions
    {
        public double CalculatePay(Employee emp)
        {
            return 50;
        }

        public double CalculateRewards(Employee emp)
        {
            return 50;
        }

        public double CalculateStockOptions(Employee emp)
        {
            return 50;
        }
    }
}