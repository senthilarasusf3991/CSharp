
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("1.Addtion 2.Subtraction 3.Multiplycation 4.Division");
            int option=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the first num: ");
            int num1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second num: ");
            int num2=int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    int add=Addtion(num1,num2);
                    System.Console.WriteLine(add);
                    break;
                }
                case 2: 
                {
                    int sub=Subtraction(num1,num2);
                    System.Console.WriteLine(sub);
                    break;
                }
                case 3:
                {
                    int mul=Multiplication(num1,num2);
                    System.Console.WriteLine(mul);
                    break;
                }
                case 4: 
                {
                    int div=Division(num1,num2);
                    System.Console.WriteLine(div);
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid input");
                    break;
                }
            }
            int Addtion(int num1,int num2)
            {
                int add =num1+num2;
                return add;
            }
            int Subtraction(int num1,int num2)
            {
                int sub=num1-num2;
                return sub;
            }
            int Multiplication(int num1,int num2)
            {
                int mul=num1*num2;
                return mul;
            }
            int Division(int num1,int num2)
            {
                int div=(num1/num2);
                return div;
            }

            
            
        }
    }
}