using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2=int.Parse(Console.ReadLine());

            int add = num1+num2;
            int sub = num1-num2;
            int multiply = num1*num2;
            int div = num1/num2;
            int rem = num1%num2;

            Console.WriteLine($"addition {add}");
            Console.WriteLine($"subraction {sub}");
            Console.WriteLine($"multiplication {multiply}");
            Console.WriteLine($"division {div}");
            Console.WriteLine($"reminder {rem}");

            Console.ReadLine();


            


        }
    }
}