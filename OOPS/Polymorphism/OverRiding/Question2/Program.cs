using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Syncfusion employee=new Syncfusion("senthil","arasu",Gender.Male,"B.Tech","Developer",20,"Chennai");
        employee.Display();
        employee.CalculateSalary();
        System.Console.WriteLine($"Salary amount : {employee.SalaryAmount}");
    }
}