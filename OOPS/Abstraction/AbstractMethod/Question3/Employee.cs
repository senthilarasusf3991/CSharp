using System;
namespace Question3
{
    public enum Gender{Default,Male,Female,Transgender}
    public class Employee
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get{s_employeeID++;return "EMP"+s_employeeID;}}
        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public int NumberOfDaysWorked { get; set; }
        public virtual void DisplaySalary()
        {
            System.Console.WriteLine($"EmployeeID is   :{EmployeeID}");
            System.Console.WriteLine($"Employee Name is:{EmployeeName}");
            System.Console.WriteLine($"Gender is     :{Gender}");
            System.Console.WriteLine($"NoOfDaysWorked :{NumberOfDaysWorked}");
        }
        
        
        
    }
}