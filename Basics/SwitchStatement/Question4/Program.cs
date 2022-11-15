
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first integer: ");
            int num1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second integer: ");
            int num2=int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("1.Addtion 2.Subtraction 3.Multiplication 4.Division 5.Exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    int add=num1+num2;
                    Console.WriteLine($"Addtion of {num1} and {num2} is {add}");
                    break;
                }
                case 2:
                {
                    int sub=num1-num2;
                    Console.WriteLine($"Subtraction of {num1} and {num2} is {sub}");
                    break;
                }
                case 3:
                {
                    int mul=num1*num2;
                    Console.WriteLine($"Multiplication of {num1} and {num2} is {mul}");
                    break;
                }
                case 4:
                {
                    int div=num1/num2;
                    Console.WriteLine($"Division of {num1} and {num2} is {div}");
                    break;
                }
                default:
                {
                    
                    Console.WriteLine("Exit");
                    break;
                }
                
            }




        }
    }
}