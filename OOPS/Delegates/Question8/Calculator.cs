using System;
namespace Question8
{
    public class Calculator
    {
        public delegate double Operation(double value1, double value2);
        public static void MainMethod()
        {
            int choice;
            
            do
            {
            System.Console.WriteLine("Enter the choice\n1.Addtion\n2.Subtraction\n3.Multiplication\n4.Division\n5.exit");
            choice=int.Parse(Console.ReadLine());
            switch ((choice))
            {
                case 1:
                {
                    Operation add=new Operation(Calculator.Addition);
                    System.Console.WriteLine($"The value of Addition is {add(6,5)}");
                    break;
                }
                case 2:
                {
                    Operation sub=new Operation(Calculator.Subtraction);
                    System.Console.WriteLine($"The value of Subtraction is {sub(10,6)}");
                    break;
                }
                case 3:
                {
                    Operation mul=new Operation(Calculator.Multiplication);
                    System.Console.WriteLine($"The value of Multiplication is {mul(10,6)}");
                    break;
                }
                case 4:
                {
                    Operation div=new Operation(Calculator.Division);
                    System.Console.WriteLine($"The value of Division is {div(10,6)}");
                    break;
                }
                case 5:
                {
                    break;
                }
                default: 
                {
                    System.Console.WriteLine("Enter the valid option");
                    break;
                }
            }
        }while(choice!=5);
        }
        public static double Addition(double number1,double number2)
        {
            return number1+number2;
        }
        public static double Subtraction(double number1,double number2)
        {
            return number1-number2;
        }
        public static double Multiplication(double number1,double number2)
        {
            return number1*number2;
        }
        public static double Division(double number1,double number2)
        {
            return number1/number2;
        }
    }

}