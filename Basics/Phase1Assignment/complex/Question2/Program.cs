
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
            double result =1;
            for(int i=1;i<=number;i++)
            {
                result=result+Math.Pow(2,i)/fact(i);

            }System.Console.WriteLine(Math.Round(result,4));
        }
        public static int fact(int number)
        {
            int product=1;
            for (int i=1;i<=number;i++)
            {
                product=product*i;

            }return product;
        }
    }
}

