
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            double celcius=double.Parse(Console.ReadLine());

            double fahrenheit=((celcius*1.8)+32);

            

            System.Console.WriteLine($"Fahrenheit = {fahrenheit}");
            
        }
    }
}