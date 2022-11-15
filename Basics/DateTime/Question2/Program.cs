
using System;
namespace Question2

{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime newDate=new DateTime();
            System.Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
            newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
            System.Console.WriteLine($"1.Complete date: {newDate.ToString("dd/MM/yyyy HH:mm:ss tt")}");
            System.Console.WriteLine($"2.short date: {newDate.ToShortDateString()}");
            System.Console.WriteLine($"3.long date: {newDate.ToString("dddd,MMMM,yyyy HH:mm:ss tt")}");
            System.Console.WriteLine($"4.12 hr format: {newDate.ToString("dd/MM/yyyy hh:mm:ss tt")}");
            System.Console.WriteLine($"5.Date only: {newDate.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"6.Time only: {newDate.ToString("hh:mm:ss tt")}");
        }
    }
}