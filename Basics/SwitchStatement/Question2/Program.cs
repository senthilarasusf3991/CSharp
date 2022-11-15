
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input: ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("monday");
                    break;

                }
                case 2:
                {
                    System.Console.WriteLine("tuesday");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("wednesday");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Thursday");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("friday");
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("saturday");
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("sunday");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("invalid input");
                    break;
                }
            }
            
        }
    }
}