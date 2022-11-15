using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the month: ");
            string month=Console.ReadLine().ToLower();
            
            if (month=="december" || month=="january" || month=="february")
            {
                System.Console.WriteLine("Winter");

            }
            else if (month=="march" || month=="april" || month=="may")
            {
                System.Console.WriteLine("spring");

            }
            else if (month=="june" || month=="july" || month=="august")
            {
                System.Console.WriteLine("summer");

            }
            else if (month=="september" || month=="october" || month=="november")
            {
                System.Console.WriteLine("rainfall");

            }
            else
            {
                System.Console.WriteLine("not valid");
            }

        }
    }
    
}