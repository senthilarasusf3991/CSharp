
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                { 
                   
                    System.Console.WriteLine("January month has 31 days.");
                    break;

                }
                case 2:
                {
                    System.Console.WriteLine("February month has 28 || 29 days.");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("March month has 31 days.");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("April month has 30 days.");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("May month has 31 days.");
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("June month has 30 days.");
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("July month has 31 days.");
                    break;
                }
                case 8:
                {
                    System.Console.WriteLine("August month has 31 days.");
                    break;
                }
                case 9:
                {
                    System.Console.WriteLine("September month has 30 days.");
                    break;
                }
                case 10:
                {
                    System.Console.WriteLine("October month has 31 days.");
                    break;
                }
                case 11:
                {
                    System.Console.WriteLine("November month has 30 days.");
                    break;
                }
                case 12:
                {
                    System.Console.WriteLine("December month has 31 days.");
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
