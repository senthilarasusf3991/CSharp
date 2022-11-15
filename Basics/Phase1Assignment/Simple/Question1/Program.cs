
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            double inch=double.Parse(Console.ReadLine());

            double centimeter= inch*2.54;
            System.Console.WriteLine($"{inch} inch is {centimeter}cm");
        }
    }
}