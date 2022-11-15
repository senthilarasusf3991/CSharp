
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("E.Excellent V.Verygood G.Good A.Average F.fail");
            char option =Convert.ToChar(Console.ReadLine().ToUpper());
            switch(option)
            {
                case 'E':
                {
                    Console.WriteLine("Excellent");
                    break;

                }
                case 'V':
                {
                    Console.WriteLine("Verygood");
                    break;
                }
                case 'G':
                {
                    Console.WriteLine("Good");
                    break;
                }
                case 'A':
                {
                    Console.WriteLine("Average");
                    break;
                }
                case 'F':
                {
                    Console.WriteLine("Fail");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }
            
        }
    }
}