using Design_Principle_In_CSharp.OCP;

Employee empFTE = new Employee(new FileLogger()) { EmployeeType = EmployeeType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee empPTE = new Employee(new FileLogger()) { EmployeeType = EmployeeType.PartTime.ToString(), TotalHoursWorked = 5 };
empFTE.Save(empFTE);

Console.Read();
