
using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime now=DateTime.Now;
            System.Console.WriteLine("Display the name of the month of the year..\n\n");
            System.Console.WriteLine($"Todays date: {now.ToString("dd/MM/yyyy")}\n");
            System.Console.WriteLine("Twelve months are ...\n");
            for (DateTime i=now; i<now.AddYears(1); i=i.AddMonths(1))
            {
                System.Console.WriteLine(i.ToString("MMMM"));
            }
        }
    }
}