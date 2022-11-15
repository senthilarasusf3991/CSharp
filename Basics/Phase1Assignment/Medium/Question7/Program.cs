
using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Starting number: ");
            int startingNumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the difference: ");
            int difference=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the number of elements: ");
            int numberOfElements=int.Parse(Console.ReadLine());

            System.Console.Write("Output series is: ");
            int arith=startingNumber;
            int sum=arith;
            System.Console.Write(arith+" ");
            for (int i=0;i<numberOfElements-1;i++)
            {
                arith=arith+difference;
                sum=sum+arith;
                System.Console.Write(arith+" ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Sum of series is {sum}");


        }
    }
}