
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            double inr=double.Parse(Console.ReadLine());

            double usd=inr*0.0122;
            double eur=inr*0.0127;
            double cny=inr*0.0879;

;
            

            System.Console.WriteLine($"{inr}INR is {usd} USD");
            System.Console.WriteLine($"{inr}INR is {eur} EUR");
            System.Console.WriteLine($"{inr}INR is {cny} CNY");
            
        }
    }
}