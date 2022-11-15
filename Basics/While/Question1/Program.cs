
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num= int.Parse(Console.ReadLine());
            int i=1;
            while (i<=num)
            {
                Console.WriteLine(i);
                i++;

            }

        }
    }
}