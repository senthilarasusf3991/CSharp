
using System;
namespace Question3

{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime newDate=new DateTime();
            System.Console.Write("Enter the date: ");
            newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
            System.Console.WriteLine($"1.Year: {newDate.Year}");
            System.Console.WriteLine($"2.Month: {newDate.Month}");
            System.Console.WriteLine($"3.Day: {newDate.Day}");
            System.Console.WriteLine($"4.Hour: {newDate.Hour}");
            System.Console.WriteLine($"5.Minutes: {newDate.Minute}");
            System.Console.WriteLine($"6.Seconds: {newDate.Second}");
            System.Console.WriteLine($"7.Millisecond: {newDate.Millisecond}");

        }
    }
}