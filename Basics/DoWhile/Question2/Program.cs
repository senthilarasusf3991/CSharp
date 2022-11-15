
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        { 
            int num;
            int sum=0;
            do
            {
                System.Console.WriteLine("Enter the number: ");
                num=int.Parse(Console.ReadLine());
                if (num>=0)
                {
                    sum=sum+num;
                }
                
            }while (num>=0);
            
            System.Console.WriteLine(sum);

        }
    }
}