using System;
namespace SwitchStatement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the choice + - * / %" );
            char command=char.Parse(Console.ReadLine());
            switch(command)
            {
                case '+':
                {
                    Console.WriteLine("The result is " + (num1+num2));
                    break;

                }
                case '-':
                {
                    Console.WriteLine("The result is " +(num1-num2));
                    break;
                }
                case '*':
                {
                    Console.WriteLine("The result is "+(num1*num2));
                    break;
                }
                case '/':
                {
                    Console.WriteLine("The result is " +(num1/num2));
                    break;
                }
                case '%':
                {
                    Console.WriteLine("The result is "+(num1%num2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Operation Invalid");
                    break;
                }
                

            }


        }
    }
}