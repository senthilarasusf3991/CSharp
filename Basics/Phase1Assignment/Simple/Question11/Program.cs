
using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a Number:   ");

            int x = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Power of the number: ");

            int y = int.Parse(Console.ReadLine());

            double ans=1;
            for (int i =1; i<=y; i++)

            {

                ans *= x;

            }
            System.Console.WriteLine($"The value of {x} ^ {y} is {ans}");
            

          

            
            
        }
    }
}