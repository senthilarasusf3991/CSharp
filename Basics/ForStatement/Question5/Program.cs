using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("Enter the input: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=0;i<=num;i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine($"Odd numbers {i}");
                    sum=sum+i;

                }
                
            }
            Console.WriteLine($"Sum of odd natural numbers upto 10 terms {sum}");
        }
    }
}