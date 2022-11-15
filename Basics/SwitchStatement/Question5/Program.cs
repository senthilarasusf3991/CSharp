
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("india pakistan bangladesh");
            string option=Console.ReadLine().ToLower();
            switch(option)
            {
                case "india":
                {
                    Console.WriteLine("1.Gambir\n 2.Ashwin\n 3.Dhoni\n 4.Jadeja");
                    break;

                }
                case "pakistan":
                {
                    Console.WriteLine("1.Afridi\n 2.Azam\n 3.Akthar\n 4.Malik");
                    break;
                    
                }
                case "bangladesh":
                {
                    Console.WriteLine("1.Shaheen\n2.Ibrahim\n 3.Rashid\n 4.Ali");
                    break;
                    
                }
                default:
                {
                    System.Console.WriteLine("Invalid input");
                    break;
                }
            }
            
        }
    }
}
