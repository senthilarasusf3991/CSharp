
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the year: ");
            int year= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Leap years from 1 to {year} is: ");
            for(int i=1;i<=year;i++)
            {
                if (i%400==0 || (i%4==0 && i%100!=0))
                {
                    Console.Write($"{i}: "+"  ");
                }
            }
        }
    }
}