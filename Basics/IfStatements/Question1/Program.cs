using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number %2==0)
            {
                Console.WriteLine($"{number} is an even integer");
                

            }
            else
            {
                Console.WriteLine($"{number} is an odd integer");
            }
            Console.ReadLine();
            

        }
    }
}