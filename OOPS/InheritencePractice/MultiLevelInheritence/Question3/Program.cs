using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo(300,"January","senthil","9842393338","sent.mail",Gender.Male,360,"Chennai",5);
        employee.CalculateSalary();
        employee.DisplaySalary();
        employee.ShowDetails();
    }
}