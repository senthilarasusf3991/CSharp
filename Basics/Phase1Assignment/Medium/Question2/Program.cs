
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp=0;
            int num1=0;
            int num2=1;
            System.Console.WriteLine("Enter the range: ");
            int range=int.Parse(Console.ReadLine());

            for (int i=0;i<range;i++)
            {
                System.Console.Write(num1+" ");
                temp=num1+num2;
                num1=num2;
                num2=temp;
            }
              
            
        }
    }
}