using Design_Principle_In_CSharp.OCP;
using Unity;

Employee empFTE = new Employee(new FileLogger()) { EmployeeType = EmployeeType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee empPTE = new Employee(new FileLogger()) { EmployeeType = EmployeeType.PartTime.ToString(), TotalHoursWorked = 5 };

IUnityContainer unityContainer = new UnityContainer();
unityContainer.RegisterType<ILogger, FileLogger>();
unityContainer.RegisterType<ILogger, DatabaseLogger>();

Employee employee = unityContainer.Resolve<Employee>();
employee.Save(empFTE);

Console.Read();
