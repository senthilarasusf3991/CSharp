using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(31,5,1);
        Attendance month2=new Attendance(29,3,0);
        Attendance month3=new Attendance(31,0,1);
        System.Console.WriteLine($"1st Month salary is {month1.TotalSalary()}");
        System.Console.WriteLine($"2nd Month salary is {month2.TotalSalary()}");
        System.Console.WriteLine($"3rd Month salary is {month3.TotalSalary()}");
    }
}