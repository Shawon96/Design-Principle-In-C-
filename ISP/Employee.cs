using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{
    public class Employee
    {
        public string EmployeeType { get; set; }
        public double TotalHoursWorked { get; set; }
        public void Save(Employee emp)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogError(ex.Message);
            }
        }
    }

    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Contractor,
        CLevel
    }
}