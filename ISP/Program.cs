using Design_Principle_In_CSharp.OCP;

Employee empFTE = new Employee() { EmployeeType = EmployeeType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee empPTE = new Employee() { EmployeeType = EmployeeType.PartTime.ToString(), TotalHoursWorked = 5 };
Employee empContractor = new Employee() { EmployeeType = EmployeeType.Contractor.ToString(), TotalHoursWorked = 15 };
Employee employeeFinance = new Employee() { EmployeeType = EmployeeType.Contractor.ToString(), TotalHoursWorked = 15 };

// EmployeeFinance employeeFinance = new EmployeeFinance();
// var totalPay = employeeFinance.CalculatePay(empFTE);
// var totalPayPTE = employeeFinance.CalculatePay(empPTE);

// Console.WriteLine("Total Paid to Full Time Employee "+totalPay);
// Console.WriteLine("Total Paid to Part Time Employee "+ totalPayPTE);

IEmployeeFinance employeeFinanceForFTE = new EmployeeFinanceForFTE();
var totalPay = employeeFinanceForFTE.CalculatePay(empFTE);
var totalRewards = employeeFinanceForFTE.CalculateRewards(empFTE);


IEmployeeFinance employeeFinanceForPTE = new EmployeeFinanceForPTE();
var totalPayPTE = employeeFinanceForPTE.CalculatePay(empPTE);
var totalRewardsForPTE = employeeFinanceForFTE.CalculateRewards(empPTE);

EmployeeReWards employeeFinanceForContractor = new EmployeeReWards();
var totalRewardsForContractor = employeeFinanceForContractor.CalculateRewards(empPTE);

IStockOptions employeeFinanceForCLevel = new EmployeeFinanceForCLevel();
var cLevelTotalPay = employeeFinanceForCLevel.CalculatePay(empPTE);
var cLevelTotalRewards = employeeFinanceForCLevel.CalculateRewards(empPTE);
var cLevelTotalStock = employeeFinanceForCLevel.CalculateStockOptions(empPTE);


Console.WriteLine("Total Paid to Full Time Employee " + totalPay);
Console.WriteLine("Total Rewards to Full Time Employee " + totalRewards);
Console.WriteLine("Total Paid to Part Time Employee " + totalPayPTE);
Console.WriteLine("Total Rewards to Part Time Employee " + totalRewardsForPTE);
// Console.WriteLine("Total Paid to Contractor Employee " + totalPayContractor);
Console.WriteLine("Total Rewards to Contractor Employee " + totalRewardsForContractor);

Console.WriteLine("Total Paid to CLevel Employee " + cLevelTotalPay);
Console.WriteLine("Total Rewards CLevel Employee " + cLevelTotalRewards);
Console.WriteLine("Total Rewards CLevel Stock" + cLevelTotalStock);

