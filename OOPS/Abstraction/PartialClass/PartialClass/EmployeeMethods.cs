using System;
namespace PartialClass
{
    public partial class Employee
    {
        //constructor
        public Employee(int id , string name)
        {
            this.EmpID=id;
            this.Name=name;

        }
        public void DisplayEmpInfo()
        {
            System.Console.WriteLine("Employee ID "+ this.EmpID + "\t Employee Name: "+this.Name);
        }
        public partial void ShowEmployeeID()
        {
            System.Console.WriteLine("your ID is "+EmpID);
        }
    }
}