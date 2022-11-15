
using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a month: ");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a year: ");
            int year=int.Parse(Console.ReadLine());
            System.Console.Write("The number of days in the given month: ");
            System.Console.Write(DateTime.DaysInMonth(year,month));
            

        }
    }
}