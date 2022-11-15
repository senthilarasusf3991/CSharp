
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            double basicSalary=double.Parse(Console.ReadLine());

            double da=basicSalary*0.1;
            double hra=basicSalary*0.1;
            double annualSalary=(basicSalary+da+hra)*12;
            double tax=annualSalary*0.05;
            
            double Salary=annualSalary-tax;
            

            System.Console.WriteLine($"salary is {Salary}");
            
            
        }
    }
}