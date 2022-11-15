using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            

            double kelvin=celsius+273.15;
            double fahrenheit=(celsius*9/5)+32;

            Console.WriteLine($"Kelvin is {kelvin}");
            Console.WriteLine($"Fahrenheit is {fahrenheit}");

            Console.ReadLine();
           

            

        }
    }
}