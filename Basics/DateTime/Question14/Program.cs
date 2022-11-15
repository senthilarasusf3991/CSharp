
using System;
namespace Question14
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter a month: ");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a number of leaves taken: ");
            int leavesTaken=int.Parse(Console.ReadLine());

            DateTime date=new DateTime(DateTime.Now.Year,month,1);
            TimeSpan daysPresent=date.AddMonths(1)-date;
            int salaryIs=(daysPresent.Days - leavesTaken)*500;
            System.Console.WriteLine($"Salary is: {salaryIs}");




        }
    }
}