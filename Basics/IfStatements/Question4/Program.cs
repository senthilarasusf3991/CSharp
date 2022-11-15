using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number: ");
            int num3=int.Parse(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine($"The 1st number {num1} is the greatest among three.");

            }
            else if (num2>num1 && num2>num3)
            {
                Console.WriteLine($"The 2nd number {num2} is the greatest among three.");

            }
            else
            {
                Console.WriteLine($"The 3rd number{num3} is the greatest among three.");
            }
            Console.ReadLine();
            
            
        }
    }
}