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
        public ILogger logger;
        public Employee(ILogger loggerInput)
        {
            this.logger = loggerInput;
        }
        public void Save(Employee emp)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                // var IsFileLoggingEnabled = true;
                // var IsDatabaseLoggingEnabled = true;

                // if (IsFileLoggingEnabled)
                // {
                //     ILogger logger = new FileLogger();
                //     logger.LogError("File");
                // }
                // if (IsDatabaseLoggingEnabled)
                // {
                //     ILogger logger = new FileLogger();
                //     logger.LogError("Database");
                // }
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