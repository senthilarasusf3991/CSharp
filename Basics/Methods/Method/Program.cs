
using System;
namespace MethodPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition="";
            do
            {

            
                System.Console.WriteLine("Enter the choice 1.Addition/n 2.Subtraction/n 3.Division/n 4.multiplication/n ");
                int option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter num1: ");
                int num1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2: ");
                int num2=Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        int sum=Addition(num1,num2);
                        Console.WriteLine(sum);
                        break;

                    }
                    case 2:
                    {
                        int diff=Subtraction(num1,num2);
                        Console.WriteLine(diff);
                        break;
                    }
                    case 3:
                    {
                        int div=Division(num1,num2);
                        Console.WriteLine(div);
                        break;
                    }
                    case 4:
                    {
                        int mul=Multiplication(num1,num2);
                        Console.WriteLine(mul);
                        break;
                    }
                    int Addition(int num1, int num2)
                    {
                        int add=num1+num2;
                        return add;
                    }
                    int Subtraction(int num1, int num2)
                    {
                        int sub=num1-num2;
                        return sub;
                    }
                    int Division(int num1, int num2)
                    {
                        int div=num1/num2;
                        return div;
                    }
                    int Multiplication(int num1, int num2)
                    {
                        int mul=num1*num2;
                        return mul;
                    }

                }
                Console.WriteLine("do you want to do again: ");
                condition=Console.ReadLine();
            }while (condition=="yes");

            
            
        }
    }
}