
using System;
namespace ExceptionalHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            try{
            System.Console.WriteLine("Enter the first number: ");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second number: ");
            int number2=int.Parse(Console.ReadLine());

            int restult=number1/number2;
            System.Console.WriteLine(restult);
            }
            catch(FormatException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            catch(DivideByZeroException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            finally
            {
                System.Console.WriteLine("Exception Handled successfully");
            }

        }
    }
}