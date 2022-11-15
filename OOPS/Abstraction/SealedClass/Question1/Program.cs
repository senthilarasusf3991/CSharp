using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("senthil");
        System.Console.WriteLine("Before update");
        employee.DisplayInfo();
        System.Console.WriteLine("After Update");
        employee.UpdateInfo("arasu");
        employee.DisplayInfo();
    }
}