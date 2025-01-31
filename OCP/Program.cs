

using Design_Principle_In_CSharp.OCP;

Employee empFTE = new Employee() { EmployeeType = EmployeeType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee empPTE = new Employee() { EmployeeType = EmployeeType.PartTime.ToString(), TotalHoursWorked = 5 };

EmployeeFinance employeeFinance = new EmployeeFinance();
var totalPay = employeeFinance.CalculatePay(empFTE);
var totalPayPTE = employeeFinance.CalculatePay(empPTE);

Console.WriteLine("Total Paid to Full Time Employee "+totalPay);
Console.WriteLine("Total Paid to Part Time Employee "+ totalPayPTE);

