
using System;
namespace Question5

{
    class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.Write("Enter the starting date: ");
            DateTime newDateOne=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the ending date: ");
            DateTime newDateTwo=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            for(int i=newDateOne.Year;i<=newDateTwo.Year-1;i++)
            
            {
                
                if(DateTime.IsLeapYear(i))
                {
                    System.Console.WriteLine($"{newDateOne.ToString("d")}: day 366 of {newDateOne.AddYears(1).Year} (Leap Year)");
                }
                else{
                    System.Console.WriteLine($"{newDateOne.ToString("d")}: day 365 of {newDateOne.AddYears(1).Year} ");
                }
                newDateOne=newDateOne.AddYears(1);
            }
            TimeSpan newTime=newDateTwo.Subtract(newDateOne);
            System.Console.WriteLine($"{newDateOne.ToString("d")}: day {newTime.Days} of {newDateTwo.AddYears(1).Year}");
  
        
        }
    }
}
