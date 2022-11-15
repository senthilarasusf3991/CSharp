
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition="";
            do 
            {
                System.Console.WriteLine("Enter the number: ");
                int num=int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    System.Console.WriteLine($"The number {num} is Even");

                }
                else
                {
                    System.Console.WriteLine("The number {num} is Odd");
                }
                System.Console.WriteLine("Do you want to continue ...Yes or no");
                condition=Console.ReadLine().ToLower();
                if (condition !="yes" && condition !="no")
                {
                    System.Console.WriteLine("Invalid input enter yes or no");
                    condition=Console.ReadLine().ToLower();
                }
 
            }while (condition=="yes");
        }
    }
}