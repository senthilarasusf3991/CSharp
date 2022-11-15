using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your age: ");
            int age=int.Parse(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("You are elegible for casting your vote.");

            }
            else
            {
                Console.WriteLine("YOu are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
    }
    
}