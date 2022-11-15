using System;
namespace Question3
{
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string Name,Gender gender,int NoOfDaysWorked)
        {
            
            EmployeeName=Name;
            Gender=gender;
            NumberOfDaysWorked=NoOfDaysWorked;
        }
        public override void DisplaySalary()
        {
            base.DisplaySalary();
            System.Console.WriteLine($"salary is   :{(NumberOfDaysWorked*600)}");
        }
        
    }
}