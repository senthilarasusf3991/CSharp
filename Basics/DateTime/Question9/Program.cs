
using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the starting year: ");
            int yearOne=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the starting year: ");
            int yearTwo=int.Parse(Console.ReadLine());
            for(int i=yearOne;i<=yearTwo;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    System.Console.WriteLine("{0} is a leap year",i);
                    DateTime leapYear=new DateTime(i,2,29);
                    DateTime nextYear=leapYear.AddYears(1);
                    System.Console.WriteLine($"one year from {leapYear.ToString("d")} is {nextYear.ToString("d")}");
                }
            }
        }
    }
}