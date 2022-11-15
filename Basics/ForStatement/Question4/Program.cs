using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
               
                Console.WriteLine($"{num} x {i} = {num*i}");

            }
        }
    }
}