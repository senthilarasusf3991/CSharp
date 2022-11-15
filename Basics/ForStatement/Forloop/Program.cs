using System;
namespace Forloop
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Even numbers
            for(int i=0; i<=25 ;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }

            }




            //sum of square of number
            Console.WriteLine("Enter the first number: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2=int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=num1;i<=num2;i++)
            {
                Console.WriteLine("square numbers are "+(i*i));
                sum=sum+(i*i);

            }
            Console.WriteLine("The sum is " + sum);
            
        }
    }
}





