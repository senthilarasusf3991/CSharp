using System;
namespace SingleInheritence3
{
    public class SalaryInfo:Attendance
    {
        public int SalaryOfTheMonth { get; set; }
        public string Month{get;set;}
        public SalaryInfo(int salary,string month,DateTime date,int noOfHoursWorked):base(date,noOfHoursWorked)
        {
            SalaryOfTheMonth=salary;
            Month=month;
            NoOfHoursWorked=noOfHoursWorked;
        }
        public void CalculateSalary()
        {
            System.Console.WriteLine($"Your salary is :{SalaryOfTheMonth}");
        }
        public void DisplaySalary()
        {
             System.Console.WriteLine($"Your salary is :{SalaryOfTheMonth}");
        }
        
    }
}
