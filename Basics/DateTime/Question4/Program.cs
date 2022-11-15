
using System;
namespace Question4

{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime newDate=new DateTime();
            System.Console.Write("Enter the date: ");
            newDate=DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine($"Day of the week for {newDate.ToShortDateString()} is {newDate.ToString("dddd")}");
        
        }
    }
}