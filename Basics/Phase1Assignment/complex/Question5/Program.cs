
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter Your date of birth: ");
            DateTime DOB=new DateTime();
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
            TimeSpan newDate=DateTime.Today.Subtract(DOB);
            Console.WriteLine("Your age is "+newDate.Days/365);
            System.Console.WriteLine("Day you were born is "+DOB.ToString("ddddd"));
            System.Console.WriteLine("Days: "+newDate.Days);
            System.Console.WriteLine("Hours: "+newDate.Hours);
            System.Console.WriteLine("Minutes: "+newDate.Minutes);
            System.Console.WriteLine("Seconds: "+newDate.Seconds);
            System.Console.WriteLine("Milliseconds: "+newDate.Milliseconds);
            


        }
    }
}

