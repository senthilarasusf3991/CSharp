using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value a: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value b: ");
            int b=int.Parse(Console.ReadLine());

            int value = a*a + 2*a*b +b*b;

            Console.WriteLine($"(a+b)**2 = {value}");
            Console.ReadLine();

        }
    }
}